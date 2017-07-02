using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class FlightControl : MonoBehaviour {

	[SerializeField]
	float DriveForce = 8.0f;
	[SerializeField]
	float Gravity = -5.0f;


	Rigidbody _rigidbody;
	SteamVR_TrackedObject _trackedObject;
	Vector3 _forwardForce;
	bool _go = false;
	SteamVR_Controller.Device device;
	void Awake() {
		_trackedObject = GetComponent<SteamVR_TrackedObject>();
		_rigidbody = this.transform.GetComponentInParent<Rigidbody>();
		if (Gravity > 0)
			{ Gravity = 0; }
	}

	void Start() {
		device = SteamVR_Controller.Input((int)_trackedObject.index);
	}

	void Update() {
		if (device.GetTouch(SteamVR_Controller.ButtonMask.Touchpad)) {
			_go = true;
		} else {
 			_go = false;
		}
	}

	void FixedUpdate() {
		if (Gravity <= 0) {
			_rigidbody.AddForce(new Vector3(0f, Gravity, 0f));
		}
		// add force
		if (_go) {
			_forwardForce = Vector3.forward;
			_rigidbody.AddForce(transform.rotation * _forwardForce * DriveForce);
			_rigidbody.maxAngularVelocity = 2f;
		}
	}
}