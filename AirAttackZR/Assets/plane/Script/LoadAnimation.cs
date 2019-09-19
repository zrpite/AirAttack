using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAnimation : MonoBehaviour {

	protected Transform m_transform;
	private Vector2 pos;
	private float speed;
	private int tip;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		pos = m_transform.position;
		if(this.gameObject.name.CompareTo("load1") == 0){
			tip = 1;
			speed = 2;
		}
		if(this.gameObject.name.CompareTo("load11") == 0){
			tip = 2;
			speed = 5;
		}
		if(this.gameObject.name.CompareTo("load111") == 0){
			tip = 3;
			speed = 3;
		}
	}
	
	// Update is called once per frame
	void Update () {
			m_transform.Translate(new Vector2(speed*Time.deltaTime,0));
			switch(tip){
				case 1: term1();break;
				case 2: term2();break;
				case 3: term3();break;
			}
	}
	void term1(){
		if(m_transform.position.x >= 6)
		m_transform.position = pos;
	}
	void term2(){
		if(m_transform.position.y >= 8)
			m_transform.position = pos;
	}
	void term3(){
		if(m_transform.position.y <= -7.5f)
			m_transform.position = pos;
	}
}
