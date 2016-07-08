using UnityEngine;
using System.Collections;

public class EraserMovement : MonoBehaviour {

    public float speed;
    public float upDownSpeed;
    public float distanceFromCenter;
    public GameObject thePlayer;
    
    private Rigidbody2D eraserRigidBody;
    private Collider2D eraserCollider;
    private Vector3 eraserStartPoint;
    private bool upOrDown;

    // Use this for initialization
    void Start () {
        eraserRigidBody = GetComponent<Rigidbody2D>();
        eraserCollider = GetComponent<PolygonCollider2D>();
        eraserStartPoint = transform.position;
        eraserRigidBody.velocity = new Vector2(speed, upDownSpeed);
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y > eraserStartPoint.y + distanceFromCenter && upOrDown) {
            eraserRigidBody.velocity = new Vector2(speed, -1 * upDownSpeed);
            upOrDown = false;
        }
        if (transform.position.y < eraserStartPoint.y - distanceFromCenter && upOrDown == false) {
            eraserRigidBody.velocity = new Vector2(speed, -1 * upDownSpeed);
            upOrDown = true;
        }
	}
}
