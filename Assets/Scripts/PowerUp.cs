using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

    private PlayerMovement player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            player.speed = 10;
        }
    }
}
