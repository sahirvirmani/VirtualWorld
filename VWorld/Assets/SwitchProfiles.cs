using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchProfiles : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		Debug.Log ("Entered");
		col.transform.GetComponent<PPManagement> ().ChangePostProcessingBehaviour (2);
		Debug.Log ("Called color change");
	}

}
