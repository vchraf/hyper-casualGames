using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class playerMove : MonoBehaviour {
	public string currentColor;
	public float JumpForce=5f;
	public Rigidbody2D circle;
	public SpriteRenderer sr;
	public Color bleu;
	public Color yallow;
	public Color pink;
	public Color purlpe;
	public static int score=0;
	public Text scoreText;
	public GameObject[] obsticle;
	public GameObject colorChanger;
	
	// Use this for initialization
	void Start () {
		SetRandomColor();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")|| Input.GetMouseButtonDown(0))
		{
			circle.velocity=Vector2.up* JumpForce;
		}
				scoreText.text=score.ToString();
	}
	void OnTriggerEnter2D(Collider2D collision){
		var plsadd=8f;
		if (collision.tag =="scored")
		{
			score++;
			Destroy(collision.gameObject);
			int swit =Random.Range(0,2);
			if (swit==0)
			{
			Instantiate(obsticle[0] ,new Vector2(transform.position.x,transform.position.y+plsadd) ,transform.rotation);	
			}else if(swit==1)
			{
			Instantiate(obsticle[1] ,new Vector2(transform.position.x,transform.position.y+plsadd) ,transform.rotation);	
			}
			else
			{
			Instantiate(obsticle[2] ,new Vector2(transform.position.x,transform.position.y+plsadd) ,transform.rotation);	
			}
			return;
		}
		if (collision.tag =="ColorChanger")
		{
			SetRandomColor();
			Destroy(collision.gameObject);
			Instantiate(colorChanger ,new Vector2(transform.position.x,transform.position.y+plsadd) ,transform.rotation);		
			return;

		}
		if (collision.tag!= currentColor)
		{
			//Destroy(gameObject);
			Debug.Log("you Died");
			EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex);
			score=0;
		}
	}
	void SetRandomColor(){
		int rand=Random.Range(0,3);
		switch (rand)
		{
			case 0:
			currentColor="Bleu";
			sr.color=bleu;
			break;
			case 1:
			currentColor="Yallow";
			sr.color=yallow;
			break;
			case 2:
			currentColor="Pink";
			sr.color=pink;
			break;
			case 3:
			currentColor="Purlpe";
			sr.color=purlpe;
			break;
		}
	}
}
