using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSpawn : MonoBehaviour {

	public GameObject boom;
	public GameObject faster;
	public float speed = 5;
	protected Transform m_transform;
	private Vector2 pos;
	private int tip;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		speed -= Time.deltaTime;
		if(speed <= 0){
			speed = 10;
			tip = (int)Random.Range(1.0f,3.0f);
			switch(tip){
				case 1:InstantiateBuff(boom); break;
				case 2:InstantiateBuff(faster);break;
			}
		}
	}
	void InstantiateBuff(GameObject G){
		pos = new Vector2(m_transform.position.x + Random.Range(0,4.0f),m_transform.position.y);
		Instantiate(G,pos,m_transform.rotation);
	}
}
