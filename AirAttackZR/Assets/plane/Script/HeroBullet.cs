using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBullet : MonoBehaviour {

	public float speed = 10;
	public int power = 1;
	protected Transform m_transform;

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
		if(other.tag == "WallTop"
		 ||other.tag == "Enemy1"
		 ||other.tag == "Enemy2"
		 ||other.tag == "Enemy3"){
			Destroy(this.gameObject);
		}
	}
}
