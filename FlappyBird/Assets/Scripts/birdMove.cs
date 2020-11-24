using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class birdMove : MonoBehaviour {
	public static int score=0;
	public Text scoreTxt;
	Rigidbody2D Bird;
	// Use this for initialization
	void Start () {
		Bird=GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Bird.velocity=new Vector2(0,5);
		}
		scoreTxt.text=score.ToString();
	}
	private void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag=="point")
		{
			score++;
			return;
		}
		
	}
	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag=="Pipes")
		{
			Destroy(gameObject);
			SceneManager.LoadScene(2);
			score=0;
		}
	}
}
