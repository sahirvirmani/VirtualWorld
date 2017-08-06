using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFreeLook : MonoBehaviour {

	Camera mainCamera;

	public float smoothSpeed;
	public float moveSpeed;
	public float speedMultiplier = 1;

	void Start() {
		mainCamera = Camera.main;
		Cursor.lockState = CursorLockMode.Locked;
	}
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftShift))
			speedMultiplier = 5;
		else
			speedMultiplier = 1;

		float h = Input.GetAxis ("Horizontal") * moveSpeed * speedMultiplier;
		float v = Input.GetAxis ("Vertical") * moveSpeed * speedMultiplier;

		float x = Input.GetAxis ("Mouse X");
		float y = Input.GetAxis ("Mouse Y");

			mainCamera.transform.position = Vector3.Lerp (mainCamera.transform.position, mainCamera.transform.position + (mainCamera.transform.forward * v) + (mainCamera.transform.right * h), Time.deltaTime * smoothSpeed);

		Vector3 newOrientation = transform.eulerAngles + new Vector3 (-y, x, 0);

		mainCamera.transform.eulerAngles = newOrientation;

	}
}
