using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
	bool colorChangeCollision = false;
	private SteamVR_Controller.Device controller {get { return SteamVR_Controller.Input((int)trackedObj.index);} }
	private SteamVR_TrackedObject trackedObj;
	// Use this for initialization
	void Start () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
		if (controller == null) {
			Debug.Log("Controller not initialized");
		}
	}

	private void onTriggerEnter(Collider collider) {
		colorChangeCollision = true;
	}

	void ChangeColorMethod() {
		if (colorChangeCollision) {
			transform.GetComponent<Renderer>().material.color = Color.yellow;
		}
	}

}
