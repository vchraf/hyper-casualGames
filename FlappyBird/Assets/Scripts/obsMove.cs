using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsMove : MonoBehaviour {
	public float speed=1.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveObstacle();
	}
	void moveObstacle(){
		transform.Translate(-speed*Time.deltaTime,0,0);
	}
}
