using UnityEngine;
using System.Collections;

public class MapRemover : MonoBehaviour {

    private Transform camera;

	// Use this for initialization
	void Start () {
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}
	
	// Update is called once per frame
	void Update () {
	    if (camera.position.x - transform.position.x > 20)
        {
            Destroy(gameObject, 0.3f);
        }
            
	}
}
