using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	void onCollisionEnter(Collision col) {
		if (col.gameObject.name == "Cube") {
			Destroy(col.gameObject);
		}
	}
}
