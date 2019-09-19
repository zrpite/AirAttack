using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Spawn : MonoBehaviour {

	public GameObject enemy3;
	protected Transform m_transform;
	private float spawn = 1;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(spawn == 1){
			spawn = 2;
			Instantiate(enemy3,m_transform.position,m_transform.rotation);
		}
	}
}
