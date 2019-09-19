using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Bullet : MonoBehaviour {
protected Transform m_transform;
	public float speed = 6;
	public int shootmode = 0;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		shootmode = 0;
	}
	// Update is called once per frame
	void Update () {
			m_transform.Translate(new Vector2(0,-speed*Time.deltaTime));
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "WallUnder"
		 ||other.tag == "WallTop"
		 ||other.tag == "WallLeft"
		 ||other.tag == "WallRight"
		 ||other.tag == "Boom"){
			Destroy(this.gameObject);
		}
	}
}
