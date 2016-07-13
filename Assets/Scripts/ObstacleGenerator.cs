using UnityEngine;
using System.Collections;

public class ObstacleGenerator : MonoBehaviour {

    public float minDistance;
    public float maxDistance;

    public GameObject pencil;
    public GameObject postIt;
    public GameObject ruler;
    public GameObject speedUp;

    //private GameObject speedUp;
    private GameObject[] obstacleChooser;
    private float pos;

    // Use this for initialization
    void Start () {

        //speedUp = GameObject.FindGameObjectWithTag("powerUp");
        obstacleChooser = new GameObject[4];
        obstacleChooser[0] = pencil;
        obstacleChooser[1] = postIt;
        obstacleChooser[2] = ruler;
        obstacleChooser[3] = speedUp;

        pos = 7f;
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > pos)
        {
            int chooser = (int)(Random.value * (obstacleChooser.Length));
            float distance = (Random.value * (maxDistance - minDistance)) + minDistance;
            Instantiate(obstacleChooser[chooser], new Vector3 (pos + distance, obstacleChooser[chooser].transform.position.y - 3f, transform.position.z), transform.rotation);
            pos = pos + distance;
        }

	}
}