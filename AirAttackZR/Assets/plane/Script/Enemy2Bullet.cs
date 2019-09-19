using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Bullet : MonoBehaviour {

	protected Transform m_transform;
	public float speed = 5;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		m_transform.Translate(new Vector2(0,speed*Time.deltaTime));
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "WallUnder"
		 || other.tag == "WallLeft"
		  || other.tag == "WallRight"
		  ||other.tag == "Boom"){
			Destroy(this.gameObject);
		}
	}
}
