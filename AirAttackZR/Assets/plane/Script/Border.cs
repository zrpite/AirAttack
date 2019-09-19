using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {

	protected Transform m_transform;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		float x = m_transform.position.x;
		float y = m_transform.position.y;
		if(m_transform.position.x > 2.4f){
			x = 2.4f;
		}
		if(m_transform.position.x < -2.5f){
			x = -2.5f;
		}
		if(m_transform.position.y < -5.6f){
			y = -5.6f;
		}
		if(m_transform.position.y > 3.5f){
			y = 3.5f;
		}
		m_transform.position = new Vector2(x,y);
	}
}
