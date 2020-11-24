using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	public GameObject obs1;
	public GameObject obs2;
	public GameObject obs3;
	public GameObject obs4;
	public GameObject positionofnewobj;
	int cont=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D collision){
		cont=Random.Range(1,5);
		if (collision.gameObject.tag=="Obstacle")
		{
			if (cont==1)
			{
				Instantiate(obs1,new Vector2(positionofnewobj.transform.position.x,obs1.transform.position.y),Quaternion.identity);
			}else if (cont==2)
			{
				Instantiate(obs2,new Vector2(positionofnewobj.transform.position.x,obs2.transform.position.y),Quaternion.identity);
			}else if (cont==3)
			{
				Instantiate(obs3,new Vector2(positionofnewobj.transform.position.x,obs3.transform.position.y),Quaternion.identity);
			}else if (cont==4)
			{
				Instantiate(obs4,new Vector2(positionofnewobj.transform.position.x,obs4.transform.position.y),Quaternion.identity);
			}
			Destroy(collision.gameObject);
		}

	}
}
