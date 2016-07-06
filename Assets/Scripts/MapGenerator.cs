using UnityEngine;
using System.Collections;

public class MapGenerator: MonoBehaviour {

    //Map Generation Fields
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    //Obstacle Generation Fields
    public GameObject obstacle;
    public float minDistanceBetweenObstacles;

    // Use this for initialization
    void Start () {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log(platformWidth);
        if (transform.position.x < generationPoint.position.x) {
            transform.position = new Vector3(transform.position.x + platformWidth * 1.280459f + distanceBetween, transform.position.y, transform.position.z);

            Instantiate(thePlatform, transform.position, transform.rotation);
            generate(new Vector3(transform.position.x, transform.position.y, transform.position.z));
        }
	}

    public void generate(Vector3 position)
    {
        float numObstacles;
        numObstacles = (float)(3f * Random.value + 1f);
        Vector3 distance = position;

        /*for (int i = 0; i < numObstacles; i++)
        {*/
            Instantiate(obstacle, distance, transform.rotation);
            distance = new Vector3(distance.x + minDistanceBetweenObstacles, distance.y, distance.z);
        //}
    }

}
