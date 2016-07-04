using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float jumpForce;
    public bool isGround;
    public bool jumped;
    public LayerMask whatIsGround;

    private Rigidbody2D playerRigidBody;
    private Collider2D myCollider;
    private Animator anim;

	// Use this for initialization
	void Start () {
        playerRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<EdgeCollider2D>();
        anim = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        isGround = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        anim.SetBool("isGround", isGround);
        if (jumped && isGround)
        {
            jumped = false;
            anim.SetBool("jumped", jumped);

        }
        
        playerRigidBody.velocity = new Vector2(speed, playerRigidBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space)){
            if (isGround) {
                playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpForce);
            }
            else if (!isGround && !jumped)
            {
                playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpForce * 1.25f);
                jumped = true;
                anim.SetBool("jumped", jumped);
            }
        }
	}
}
