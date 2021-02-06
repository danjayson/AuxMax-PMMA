using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreamVideoButton : MonoBehaviour {

	public StreamVideo streamVideo;

	public void PlayButton(){
		streamVideo.videoPlayValue = 1;
	}

	public void StopButton(){
		streamVideo.videoPlayValue = 0;
	}
}
