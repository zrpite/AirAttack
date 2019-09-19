using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Spawn : MonoBehaviour {

	public GameObject enemy1;
	protected Transform m_transform;
	private Vector2 pos;
	protected UILabel score;
	public float spawnspeed = 0.6f;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		score = GameObject.Find("Score").GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
		spawnspeed -= Time.deltaTime;
		if(spawnspeed <= 0){
			spawnspeed = 0.6f;
			if(int.Parse(score.text) >= 1000)
			spawnspeed = 2;
			pos = new Vector2(m_transform.position.x + Random.Range(0,4.0f),m_transform.position.y);
			Instantiate(enemy1,pos,m_transform.rotation);
		}
	}
}
