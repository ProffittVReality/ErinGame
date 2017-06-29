using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTrack : MonoBehaviour {
	public Text scoreText;

	private int score;
	private bool pollinated;
	// Use this for initialization
	void Start () {
		score = 0;
		pollinated = false;
		scoreText.text = "Score: " + score;
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Ball")) {
			score++;
			//other.gameObject.SetActive (false);
			//pollinated = true;
			scoreText.text = "Score: " + score.ToString ();
		}
	}
		
	// Update is called once per frame

}
