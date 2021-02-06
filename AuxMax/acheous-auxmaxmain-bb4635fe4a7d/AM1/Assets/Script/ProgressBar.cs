using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

	public Slider slider;
	public int progressRate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = progressRate;
	}
		
	public void progressIndicator(){
		progressRate++;
	}
}
