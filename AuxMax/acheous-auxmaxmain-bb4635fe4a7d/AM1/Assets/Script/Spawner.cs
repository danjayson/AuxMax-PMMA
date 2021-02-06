using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Transform spawnPoint;
	public float spawnTime = 3f;
	public GameObject water;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn(){
		Instantiate (water, spawnPoint.position, spawnPoint.rotation);

	}
}
