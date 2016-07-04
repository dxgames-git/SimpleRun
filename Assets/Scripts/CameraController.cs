using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject thePlayer;
    private float level;

	// Use this for initialization
	void Start () {
        thePlayer = GameObject.FindGameObjectWithTag("Player");
        level = 0.96f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(thePlayer.transform.position.x + 3.2f, level, transform.position.z);
	}
}
