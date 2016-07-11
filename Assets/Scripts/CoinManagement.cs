using UnityEngine;
using System.Collections;
using System;

public class CoinManagement : MonoBehaviour {

    public float scoreCoin;

    private ScoreManager score;

	// Use this for initialization
	void Start () {
        score = FindObjectOfType<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            score.coinScoreAddition(scoreCoin);
            Destroy(gameObject);
        }
    }
}