using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InlinePump_Model : MonoBehaviour {



	public GameObject theObject;
	public float passiveRotationSpeed = 10; //automatic rotation
	public float activeRotationSpeed = 5; // rotation using the mouse
	bool stopRotation = false;
	//public Text _Text;
	Animator _Animator;
	bool expand = false;

	//========= Object Reference ===========
	//public GlowObjectCmd _glowObjectCmd; //script

	void Start () {
		_Animator = gameObject.GetComponent<Animator>();
	}

	void Update () {
		ObjectRotate ();
		_Animator.SetBool ("Expanded", expand);

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


	}

	public void GoToPart(){


	}

	public void Return(){
		expand = false;

	}
}