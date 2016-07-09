using UnityEngine;
using System.Collections;

public class EraserMovement : MonoBehaviour {

    public float distanceToPlayer;
    public float eraserSpeed;
    public float eraserRange;

    private GameObject thePlayer;
    private float timeCounter;
    private Rigidbody2D eraserRigidBody;
    private int count;

    // Use this for initialization
    void Start () {
        timeCounter = 0f;
        thePlayer = GameObject.FindGameObjectWithTag("Player");
        eraserRigidBody = GetComponent<Rigidbody2D>();
        count = 0;
    }
	
	// Update is called once per frame
	void Update () {
        timeCounter += Time.deltaTime;
        if (timeCounter >= 2f * Mathf.PI)
        {
            timeCounter -= 2f * Mathf.PI;
        }
        eraserRigidBody.velocity = new Vector2(distanceToPlayer, Mathf.Sin(timeCounter * eraserSpeed) * eraserRange * Time.deltaTime);
        if (count == 100)
        {
            Debug.Log(count);
            Application.LoadLevel("Dead Scene");
        }
       // OnTriggerStay2D(thePlayer.GetComponent<Collider2D>());
       // transform.position = new Vector3(thePlayer.transform.position.x - distanceToPlayer, Mathf.Sin(timeCounter * eraserSpeed) * eraserRange * Time.deltaTime, thePlayer.transform.position.z);
	}
  /*  void OnTriggerStay2D(Collider2D other)
    {
        count++;
    }*/

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }
}
