using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

    public float duration;

    private PlayerMovement player;
    private EraserMovement eraser;
    private bool didSpeedUp;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        eraser = GameObject.FindGameObjectWithTag("Eraser").GetComponent<EraserMovement>();
        didSpeedUp = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (didSpeedUp && Time.time > duration) {
            player.speed = 6;
            eraser.distanceToPlayer = 6;
        }
	
	}
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            player.speed = 10;
            eraser.distanceToPlayer = 9;
            didSpeedUp = true;
        }
    }
}
