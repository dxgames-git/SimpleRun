using UnityEngine;
using System.Collections;

public class ObstaclesGenerator : MonoBehaviour {

    public GameObject obstacle;
    public float distanceObstacles;
    private float numObstacles;

    void Start()
    {
        numObstacles = (float)(3 * Random.value + 1);
    }

    public void generate(Vector3 position)
    {
        Vector3 distance = position;

        for (int i = 0; i < numObstacles; i++)
        {
            Instantiate(obstacle, distance, transform.rotation);
            distance = new Vector3(distance.x + distanceObstacles, distance.y, distance.z);
        }
    }
}
