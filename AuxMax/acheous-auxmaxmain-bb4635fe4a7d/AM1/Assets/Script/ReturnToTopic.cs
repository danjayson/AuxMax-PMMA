using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToTopic : MonoBehaviour 
{
	public GameObject[] pageNumber;
	public GameObject page1;
	public static int x;
	public int y;
	//static bool awake;
	bool sleepPage1;

	void Start(){
		if(x != 0){
			page1.SetActive(false);
			Debug.Log (x);
			pageNumber[x].SetActive(true);
			x = 0;
		}

	}

	void Update(){

	}

	public void SetActicePage(){
		x = y;
		//Debug.Log (x);
	}
}
