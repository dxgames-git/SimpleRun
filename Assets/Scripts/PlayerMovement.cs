﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float jumpForce;
    public bool isGround;
    public bool jumped;
    public bool up;
    public LayerMask whatIsGround;
    public GameObject eraser;

    //PowerUp
    public bool didSpeedUp;
    public float duration;
    private EraserMovement eraserMove;

    private Rigidbody2D playerRigidBody;
    private Collider2D myCollider;
    private Animator anim;


	// Use this for initialization
	void Start () {
        playerRigidBody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<EdgeCollider2D>();
        anim = gameObject.GetComponent<Animator>();
        eraserMove = GameObject.FindGameObjectWithTag("Eraser").GetComponent<EraserMovement>();
        didSpeedUp = false;
    }
	
	// Update is called once per frame
	void Update () {
        isGround = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        up = playerRigidBody.velocity.y > 0;

        anim.SetBool("isGround", isGround);
        anim.SetBool("up", up);
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
        if (didSpeedUp && Time.deltaTime > duration)
        {
            speed = 6;
            eraserMove.distanceToPlayer = 6;
        }
    }
}
