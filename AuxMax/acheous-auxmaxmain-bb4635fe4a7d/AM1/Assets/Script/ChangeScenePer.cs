﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenePer : MonoBehaviour {

	public Animator transitionAnim;
	public string sceneName;

	void Update () {
		/* if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene("SelectionMenu");
		} */
	}

	public void OnMouseDown(){
		StartCoroutine (LoadScene ());
	}

	public void LoadOtherScene(){
		StartCoroutine (LoadScene());
	}

	IEnumerator LoadScene(){
		transitionAnim.SetTrigger("end");
		yield return new WaitForSeconds(1.5f);
		SceneManager.LoadScene(sceneName);
	}
}
