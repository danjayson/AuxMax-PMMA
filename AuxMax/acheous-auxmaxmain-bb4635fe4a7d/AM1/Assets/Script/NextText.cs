using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextText : MonoBehaviour {

	public GameObject previousText;
	public GameObject currentText;
	public GameObject nextText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void next(){
		currentText.SetActive(false);
		nextText.SetActive(true);
	}

	public void previous(){
		previousText.SetActive(true);
		currentText.SetActive(false);
	}
}
