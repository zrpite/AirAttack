using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Spawn : MonoBehaviour {

	public GameObject enemy2;
	protected Transform m_transform;
	private Vector2 pos;
	public float spawnspeed = 15;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		spawnspeed -= Time.deltaTime;
		if(spawnspeed <= 0){
			spawnspeed = 15;
			pos = new Vector2(m_transform.position.x + Random.Range(0,4.0f),m_transform.position.y);
			Instantiate(enemy2,pos,m_transform.rotation);
		}
	}
}
