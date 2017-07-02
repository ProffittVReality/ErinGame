using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTrack : MonoBehaviour {
	public Text scoreText;
	public GameObject winText;
	public GameObject myEnemy;
	public GameObject myEnemy1;
	public GameObject myEnemy2;


	private int score;
	bool gameWon;
	//private bool pollinated;
	// Use this for initialization
	void Start () {
		gameWon = false;
		score = 5;
		//pollinated = false;
		scoreText.text = "Score: " + score;
		winText.SetActive (false);
	}

	void Update() {
		if (score >= 6) {
			EndGame ();
		}

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("Ball")) {
			score++;
			other.gameObject.SetActive (false);
			//pollinated = true;
			scoreText.text = "Score: " + score.ToString ();
		}
		if (other.gameObject.CompareTag ("Done")) {
			other.gameObject.SetActive (true);
		}
		if (score == 6) {
			gameWon = true;
		}
	}

	void EndGame() {
		if (gameWon) {
			myEnemy.SetActive (false);
			myEnemy1.SetActive (false);
			myEnemy2.SetActive (false);
			winText.SetActive (true);

		}
	}
		
	// Update is called once per frame

}
