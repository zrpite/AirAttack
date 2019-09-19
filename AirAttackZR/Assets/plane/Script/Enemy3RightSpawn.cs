using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3RightSpawn : MonoBehaviour {

	public GameObject enemy2;
	protected Transform m_transform;
	private Vector2 pos;
	public bool spawnspeed = true;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(spawnspeed){
			spawnspeed = false;
			pos = new Vector2(m_transform.position.x,m_transform.position.y);
			Instantiate(enemy2,pos,m_transform.rotation);
		}
	}
}
