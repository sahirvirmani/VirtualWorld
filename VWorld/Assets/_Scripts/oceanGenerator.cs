using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oceanGenerator : MonoBehaviour {

	public GameObject Waves;

	Transform[] posArray;

	// Use this for initialization
	void Start () { 
		posArray = new Transform[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) {
			posArray[i] = transform.GetChild (i);
		}
		foreach(Transform p in posArray) {
			Debug.Log ("p is at " + p.position.x);
			Instantiate (Waves, p.position, p.rotation, p);
		}
	}
}
