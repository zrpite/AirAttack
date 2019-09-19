using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour {
	protected Transform m_transform;
	protected HeroManager able;
	private float speed = 3;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		able = this.GetComponent<HeroManager>();
	}
	
	// Update is called once per frame
	void Update () {
		float mx = 0;
		 float my = 0;
		if(m_transform.position.x > 2.4f){
			m_transform.Translate(new Vector2(-(mx + speed*Time.deltaTime),0));
		}
		if(m_transform.position.x < -2.5f){
			m_transform.Translate(new Vector2(mx + speed*Time.deltaTime,0));
		}
		if(m_transform.position.y < -5.6f){
			m_transform.Translate(new Vector2(0,my + speed*Time.deltaTime));
		}
		if(m_transform.position.y > 3.5f){
			m_transform.Translate(new Vector2(0,-(my + speed*Time.deltaTime)));
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			my += speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			my -= speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			mx -= speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			mx += speed * Time.deltaTime;
		}
		if(able.controlable)
			m_transform.Translate(new Vector2(mx,my));
	}
}
