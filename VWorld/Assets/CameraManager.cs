using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

	public Camera waterCamera;
	public Camera earthCamera;
	public Camera airCamera;
	public Camera fireCamera;
	public Camera defCamera;

	public void Start() {
		DisableCamera ();
		waterCamera.enabled = true;
	}

	public void DisableCamera() {
		waterCamera.enabled = false;
		earthCamera.enabled = false;
		airCamera.enabled = false;
		fireCamera.enabled = false;
		defCamera.enabled = false;
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			waterCamera.enabled = true;
			fireCamera.enabled = false;
			earthCamera.enabled = false;
			airCamera.enabled = false;
			defCamera.enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			waterCamera.enabled = false;
			fireCamera.enabled = true;
			earthCamera.enabled = false;
			airCamera.enabled = false;
			defCamera.enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			waterCamera.enabled = false;
			fireCamera.enabled = false;
			earthCamera.enabled = true;
			airCamera.enabled = false;
			defCamera.enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			waterCamera.enabled = false;
			fireCamera.enabled = false;
			earthCamera.enabled = false;
			airCamera.enabled = true;
			defCamera.enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.Alpha5)) {
			waterCamera.enabled = false;
			fireCamera.enabled = false;
			earthCamera.enabled = false;
			airCamera.enabled = false;
			defCamera.enabled = true;
		}
	}
}
