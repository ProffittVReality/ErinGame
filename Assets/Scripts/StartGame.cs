using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public GameObject myButton;
	public GameObject myEnemy;
	public GameObject myEnemy1;
	public GameObject myEnemy2;
	public GameObject instructionText;
	public GameObject scoreText;
	public GameObject healthText;
	public GameObject healthSlider;

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("GameController")) {
			//EnemyMovement.activate ();
			myButton.SetActive (false);
			myEnemy.SetActive (true);
			myEnemy1.SetActive (true);
			myEnemy2.SetActive (true);
			instructionText.SetActive (false);
			scoreText.SetActive (true);
			healthText.SetActive (true);
			healthSlider.SetActive (true);

		}
	}
	// Use this for initialization
	void Start () {
		myEnemy.SetActive (false);
		myEnemy1.SetActive (false);
		myEnemy2.SetActive (false);
		scoreText.SetActive (false);
		healthText.SetActive (false);
		healthSlider.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
