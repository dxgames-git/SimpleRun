using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

    private PlayerMovement player;
    private EraserMovement eraser;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        eraser = GameObject.FindGameObjectWithTag("Eraser").GetComponent<EraserMovement>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            player.speed = 10;
            eraser.distanceToPlayer = 9.5f;
            player.didSpeedUp = true;
            Destroy(gameObject);
        }
    }
}
