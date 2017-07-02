using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthTrack : MonoBehaviour {

	public int beginHealth = 100;
	public int currHealth;
	public Text healthText;
	bool hit = false;
	public AudioClip hurtClip;
	public Slider healthSlider;
	AudioSource playerAudio;
	bool isDead;

	void Start() {
		playerAudio = GetComponent<AudioSource> ();
		currHealth = 100;
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("ZomTeddy") && !isDead) {
			hit = true;
			currHealth -= 20;
			playerAudio.clip = hurtClip;
			playerAudio.Play ();
			healthSlider.value = currHealth;
			healthText.text = "Health: " + currHealth.ToString ();
			if (currHealth == 0) {
				isDead = true;
			}
		}
	}

	void onTriggerExit(Collider other) {
		hit = false;
	}

	/*public void TakeDamage() {
		if (hit) {
			currHealth -= 5;
		}
		playerAudio.clip = hurtClip;
		playerAudio.Play ();
		hit = false;
	}
	*/
		
	
	// Update is called once per frame
	void Update () {
		healthText.text = "Health: " + currHealth.ToString ();
		healthSlider.value = currHealth;
	}
}
