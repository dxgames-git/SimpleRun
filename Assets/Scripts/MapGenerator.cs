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
    public GameObject coin;

    public float minDistanceBetweenObstacles;
    public float barNumber;

    private GameObject[] obstacleChooser;
    //private GameObject coin;

    // Use this for initialization
    void Start () {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
        obstacleChooser = new GameObject[3];
        obstacleChooser[0] = pencil;
        obstacleChooser[1] = postIt;
        obstacleChooser[2] = ruler;
        //coin = GameObject.FindGameObjectWithTag("coin");
    }
	
	// Update is called once per frame
	void Update () {

        if (transform.position.x < generationPoint.position.x) {
            transform.position = new Vector3(transform.position.x + platformWidth * 1.280459f + distanceBetween, transform.position.y, transform.position.z);

            Instantiate(thePlatform, transform.position, transform.rotation);

            //generating different angles

            generate(new Vector3(transform.position.x, transform.position.y, transform.position.z));
            coinGenerator(new Vector3(transform.position.x, transform.position.y, -1));
        }
	}

    public void generate(Vector3 position)
    {
        int num1 = (int)(3 * Random.value);
        int num2 = (int)(3 * Random.value);
        while (num1 == num2)
        {
            num2 = (int)(3 * Random.value);
        }
        float randomRotation = 90 * Random.value;
        Vector3 distance = new Vector3(position.x + 20 * Random.value, position.y - 5, -1);
        if (Random.Range(0f, 100f) < barNumber)
        {
            Instantiate(obstacleChooser[num1], distance, Quaternion.Euler(90 * Random.value, 90 * Random.value, 0));
            distance = new Vector3(distance.x + minDistanceBetweenObstacles, distance.y, distance.z);
            Instantiate(obstacleChooser[num2], distance, Quaternion.Euler(90 * Random.value, 90 * Random.value, 0));
        }
    }
    void coinGenerator(Vector3 position) {
        if (Random.Range(0f, 100f) > barNumber) {
            Instantiate(coin, position, coin.transform.rotation);
        }
    }
}
