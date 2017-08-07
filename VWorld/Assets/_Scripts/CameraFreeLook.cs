using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFreeLook : MonoBehaviour {

	public float smoothSpeed;
	public float moveSpeed;
	public float speedMultiplier = 1;

	void Start() {
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

			transform.position = Vector3.Lerp (transform.position, transform.position + (transform.forward * v) + (transform.right * h), Time.deltaTime * smoothSpeed);

		Vector3 newOrientation = transform.eulerAngles + new Vector3 (-y, x, 0);

		transform.eulerAngles = newOrientation;

	}
}
