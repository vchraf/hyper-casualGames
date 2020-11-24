using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retation : MonoBehaviour {
	public float retationspeed=100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f,0f,retationspeed*Time.deltaTime);
	}
}
