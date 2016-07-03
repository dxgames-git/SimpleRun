using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float jumpForce;

    private Rigidbody2D playerRigidBody;

	// Use this for initialization
	void Start () {
        playerRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        playerRigidBody.velocity = new Vector2(speed, playerRigidBody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space)){
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, jumpForce);
        }
	}
}
