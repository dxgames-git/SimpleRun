using UnityEngine;
using System.Collections;

public class MapGenerator: MonoBehaviour {

    //Map Generation Fields
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    //Obstacle Generation Fields
    public GameObject pencil;
    public GameObject postIt;
    public GameObject ruler;
    public float minDistanceBetweenObstacles;
    private GameObject[] obstacleChooser;

    // Use this for initialization
    void Start () {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
        obstacleChooser[0] = pencil;
        obstacleChooser[1] = postIt;
        obstacleChooser[2] = ruler;
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
        int num1 = (int)(2 * Random.value + 1);
        int num2 = (int)(2 * Random.value + 1);
        while (num1 != num2)
        {
            num2 = (int)(2 * Random.value + 1);
        }
        Vector3 distance = position;
        Instantiate(obstacleChooser[num1], distance, transform.rotation);
        distance = new Vector3(distance.x + minDistanceBetweenObstacles, distance.y, distance.z);
        Instantiate(obstacleChooser[num2], distance, transform.rotation);
    }

}
