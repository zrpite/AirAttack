using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Shoot : MonoBehaviour {

	public GameObject enemy2bullet;
	public float shootspeed = 1f;
	protected Transform m_transform;
	protected GameObject hero;
	private Vector2 pos;
	private Vector2 p1,p2;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		hero = GameObject.FindWithTag("Hero");
	}
	
	// Update is called once per frame
	void Update () {
		shootspeed -= Time.deltaTime;
		if(shootspeed <= 0){
			shootspeed = 1f;
			pos = new Vector2(m_transform.position.x,m_transform.position.y - 0.5f);
			p1 = Camera.main.WorldToScreenPoint(hero.transform.position);
			p2 = Camera.main.WorldToScreenPoint(enemy2bullet.transform.position);
			Instantiate(enemy2bullet,pos,Quaternion.AngleAxis(-Mathf.Atan2(
				p1.x-p2.x,
				p1.y-p2.y
				)*Mathf.Rad2Deg,enemy2bullet.transform.forward));
		}
	}
}
