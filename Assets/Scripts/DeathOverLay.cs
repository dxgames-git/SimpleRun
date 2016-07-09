using UnityEngine;
using System.Collections;

public class DeathOverLay : MonoBehaviour {

    public GameObject eraser;

    private Transform camera;
    private GameObject thePlayer;

	// Use this for initialization
	void Start () {
        camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        thePlayer = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if (thePlayer == null)
        {
            GUI.TextField(new Rect(camera.transform.position.x - 100, camera.transform.position.x + 100, camera.transform.position.y - 50, camera.transform.position.y + 50), "YOU LOST");
        }
    }
}
