using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFlowScript : MonoBehaviour {

	public Transform[] target;
	public float speed;
	int x;
	public int destroyPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float flow = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target[x].position, flow);

		if( this.transform.position == target[x].position){
			x++;
		}
		if (x == destroyPoint){
			Destroy(gameObject);
		}
	}
}
