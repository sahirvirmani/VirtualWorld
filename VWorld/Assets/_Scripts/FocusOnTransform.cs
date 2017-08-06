using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.PostProcessing{
	[ExecuteInEditMode]
	public class FocusOnTransform : MonoBehaviour {
		public Transform focusObject;
		DepthOfFieldModel depthOfField;
		DepthOfFieldModel.Settings depthOfFieldSettings;
		public bool curveBased;//Determines if it uses a fixed value, or a curve. Useful to test values quickly, which can be later used by the curve. 
		[RangeAttribute(0.1f, 32f)] public float aperture;
		[RangeAttribute(1, 300f)] public float focalLength;
		public AnimationCurve focalLengthCurve;
		[SerializeField] private float distance;//Serialized so that we can see the distance from the camera to the target object, from the editor. 

		// Use this for initialization
		void Start () {
			depthOfField = GetComponent<PostProcessingBehaviour>().profile.depthOfField;
			depthOfFieldSettings = GetComponent<PostProcessingBehaviour>().profile.depthOfField.settings;
		}

		// Update is called once per frame
		void Update () {
			distance = Vector3.Distance(transform.position, focusObject.position);
			depthOfFieldSettings.focusDistance = distance;
			depthOfFieldSettings.aperture = aperture;
			if(curveBased) depthOfFieldSettings.focalLength = focalLengthCurve.Evaluate(distance); 
			else depthOfFieldSettings.focalLength = focalLength;
			depthOfField.settings = depthOfFieldSettings;
		}
	}
}
