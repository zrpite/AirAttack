using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Bullet : MonoBehaviour {

	protected Transform m_transform;
	public float speed = 4;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		m_transform.Translate(new Vector2(0,-speed*Time.deltaTime));
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "WallUnder"
		 ||other.tag == "Boom"){
			Destroy(this.gameObject);
		}
	}

}
