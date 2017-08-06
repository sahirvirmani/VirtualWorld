using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour {

	Renderer renderer;
	public Color mainColor;
	public Color specColor;

	void Start() {
		renderer = GetComponent<Renderer> ();
		renderer.material.SetColor ("_Color", mainColor);
		renderer.material.SetColor ("_SpecColor", specColor);
		renderer.material.SetFloat ("_WaveLength", 0.1f);
		renderer.material.SetFloat ("_WaveHeight", 0.1f);
	}
}
