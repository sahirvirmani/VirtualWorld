using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateOcean : MonoBehaviour {

	public int length;
	public int breadth;

	public GameObject Waves;

	Vector3 nextPosition;

	float zDistance = 40f;
	float xDistance = 40f;

	void Start () {
		nextPosition = transform.position;
		Debug.Log ("Start nexpos = " + nextPosition);
		for (int i = 0; i < length; i++) {
			for (int j = 0; j < breadth; j++) {
				nextPosition += new Vector3 (0, 0, zDistance);
				Debug.Log (nextPosition.magnitude);
				Instantiate (Waves, transform.position + new Vector3(0, 0, zDistance * j), transform.rotation * Quaternion.Euler (270, 0, 0), transform);
			}
			nextPosition += new Vector3 (xDistance, 0, 0);
			//nextPosition -= new Vector3 (0, 0, (zDistance * breadth));
		}
	}
}
