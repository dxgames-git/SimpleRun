using UnityEngine;
using System.Collections;

public class ObstacleGenerator : MonoBehaviour {

    public float minDistance;
    public float maxDistance;

    public GameObject pencil;
    public GameObject postIt;
    public GameObject ruler;

    private GameObject[] obstacleChooser;
    private float pos;

    // Use this for initialization
    void Start () {

        obstacleChooser = new GameObject[3];
        obstacleChooser[0] = pencil;
        obstacleChooser[1] = postIt;
        obstacleChooser[2] = ruler;

        pos = 7f;
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > pos)
        {
            int chooser = (int)(Random.value * (obstacleChooser.Length - 1));
            float distance = (Random.value * (maxDistance - minDistance)) + minDistance;
            Instantiate(obstacleChooser[chooser], new Vector3 (pos + distance, -5f, transform.position.z), transform.rotation);
            pos = pos + distance;
        }

	}
}
