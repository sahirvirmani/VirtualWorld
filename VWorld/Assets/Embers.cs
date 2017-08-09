using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Embers : MonoBehaviour {

	public Color baseColor;

	Material material;
	Renderer renderer;
	Light emissiveLight;

	float rand;

	void Start() {
		renderer = GetComponent<Renderer> ();
		material = renderer.material;
		emissiveLight = GetComponent<Light> ();

		rand = Random.Range (0.5f, 1.5f);
		Debug.Log ("rand is " + rand);
	}

	void Update() {

		float emission = Mathf.PingPong (Time.time * rand, 1.0f);
		Color finalColor = baseColor * Mathf.LinearToGammaSpace (emission);

		material.SetColor ("_EmissionColor", finalColor);

		emissiveLight.intensity = Mathf.PingPong (Time.time * rand, 1.0f);
	}

}
