using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Shoot : MonoBehaviour {

	public GameObject enemy1bullet;
	public float shootspeed = 1;
	protected Transform m_transform;
	private Vector2 pos;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		shootspeed -= Time.deltaTime;
		if(shootspeed <= 0){
			shootspeed = 2;
			pos = new Vector2(m_transform.position.x,m_transform.position.y-0.3f);
			Instantiate(enemy1bullet,pos,m_transform.rotation);
		}
	}
}
