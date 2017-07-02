using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
	bool colorChangeCollision = false;
	
	public Material[] material;
	Renderer rend;
		//Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		rend.sharedMaterial = material[0];
		//trackedObj = GetComponent<SteamVR_TrackedObject>();
	}

	void Update() {
		ChangeColorMethod ();
	}

	/*void OnCollisionEnter(Collision collision) {
		Debug.Log ("THERE WAS A COLLISION YAY");
		colorChangeCollision = true;
		print("Collisiion");
		//if (collision.gameObject.name == "Cube") {
		//Destroy (this.gameObject);
		//}
	}
	*/

	void OnTriggerEnter(Collider collider) {
		print("Collison");
		if (collider.gameObject.CompareTag ("GameController")) {
			colorChangeCollision = true;
		}
	}

	void ChangeColorMethod() {
		
		if (colorChangeCollision) {
			rend.sharedMaterial = material[1];
		}
	}

}
