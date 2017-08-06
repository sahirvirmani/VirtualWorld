using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class PPManagement : MonoBehaviour {

	public PostProcessingProfile water;
	public PostProcessingProfile earth;
	public PostProcessingProfile air;
	public PostProcessingProfile fire;
	public PostProcessingProfile def;

	PostProcessingProfile[] profileArray;

	void Start() {
		profileArray = new PostProcessingProfile[5];
		profileArray [1] = water;
		profileArray [1] = earth;
		profileArray [1] = air;
		profileArray [1] = fire;
		profileArray [1] = def;
		Debug.Log ("processing array created");
	}

	public void ChangePostProcessingBehaviour(int index) {
		PostProcessingProfile currentProfile = transform.GetComponent<PostProcessingProfile> ();
		currentProfile.colorGrading.settings = profileArray [index].colorGrading.settings;
		Debug.Log ("Changed color settings");
	}

}
