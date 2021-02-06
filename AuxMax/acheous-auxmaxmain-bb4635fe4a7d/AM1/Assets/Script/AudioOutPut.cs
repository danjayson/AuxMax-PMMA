using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioOutPut : MonoBehaviour {

	AudioSource audioSource;
	bool bool_muteorplay = false;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AudioMute(){
		//audioSource.mute = !audioSource.mute;
		if (bool_muteorplay == true) {
			AudioListener.pause = !AudioListener.pause;
		} 
		else 
		{
			audioSource.Play ();
		}
		bool_muteorplay = true;
	}
}
