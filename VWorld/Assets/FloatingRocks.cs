using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingRocks : MonoBehaviour {

	float posY, randomness;
	float height;

	void Start() {
		height = transform.position.y;
		randomness = Random.value;
	}

	void Update() {
		posY = Mathf.Sin (Time.time);
		transform.position = new Vector3 (transform.position.x, (height + (posY * randomness * 1.5f)), transform.position.z);
		Debug.Log (posY);
	}

}
