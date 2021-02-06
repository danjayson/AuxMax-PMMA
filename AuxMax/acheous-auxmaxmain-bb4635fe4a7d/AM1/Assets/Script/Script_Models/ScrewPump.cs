using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrewPump : MonoBehaviour {

	public GameObject theObject;
	public float passiveRotationSpeed = 10; //automatic rotation
	public float activeRotationSpeed = 5; // rotation using the mouse
	bool stopRotation = false;
	Animator _Animator;
	bool expand, bool_valve;
	public GlowObjectCmd _glowObject;

	void Start () {
		_Animator = gameObject.GetComponent<Animator>();
	}

	void Update () {
		ObjectRotate ();
		_Animator.SetBool ("Expanded", expand);
		_Animator.SetBool ("ValveHousing", bool_valve);
//		_Animator.SetBool ("ShaftAssembly", bool_shaft);
	}

	void OnMouseDrag(){
		float rotationX = Input.GetAxis ("Mouse X") * activeRotationSpeed * Mathf.Deg2Rad;
		float rotationY = Input.GetAxis ("Mouse Y") * activeRotationSpeed * Mathf.Deg2Rad;

		theObject.transform.RotateAround (Vector3.up, -rotationX);
		theObject.transform.RotateAround (Vector3.left, -rotationY);
	}

	void ObjectRotate(){
		if(stopRotation == false){
			theObject.transform.Rotate (Vector3.up * passiveRotationSpeed * Time.deltaTime);
		}
	}

	public void RotationStopper(){
		stopRotation = !stopRotation;
	}

	public void OriginalPosition(){
		theObject.transform.rotation = Quaternion.identity;
	}

	public void Expand(){
		expand = true;
		//============== Main 3 Parts ===================
		if (_glowObject._Text.text == "Valve Housing") {
			bool_valve = true;
			//			valveHousing.SetActive (false);
			//			cover.SetActive (false);	
		}
//		if (_glowObject._Text.text == "Shaft Assembly") {
			//bool_shaft = true;
			//			pumpBody.SetActive (false);
			//			cover.SetActive (false);
//		}
//		if (_glowObject._Text.text == "Complete Cover") {
			//			bool_cover = true;
			//			pumpBody.SetActive (false);
			//			valveHousing.SetActive (false);
//		}
	}



	public void Return(){
		_glowObject._Text.text = null;
		expand = false;
		bool_valve = false;
//		bool_shaft = false;
	}
}
