using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject thePlayer;
    private float level;

	// Use this for initialization
	void Start () {
        thePlayer = GameObject.FindGameObjectWithTag("Player");
        level = thePlayer.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(thePlayer.transform.position.x + 3, level, transform.position.z);
	}
}
