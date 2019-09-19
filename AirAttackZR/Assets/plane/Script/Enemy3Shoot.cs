using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Shoot : MonoBehaviour {

	public GameObject enemy3bullet;
	public float shootspeed = 0.05f;
	protected Transform m_transform;
	private Vector2 posi;
	private float angle = -180;
	private bool flag = false;

	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(m_transform.position.y <= 2)
		flag =true;
		else flag = false;
		if(flag)
		Circleshoot();
	}
	void Circleshoot(){
		shootspeed -= Time.deltaTime;
		angle += Time.deltaTime*200;
		if(shootspeed <= 0){
			shootspeed = 0.05f;
			posi = new Vector2(m_transform.position.x,m_transform.position.y+0.38f);
			Instantiate(enemy3bullet,posi,Quaternion.AngleAxis(angle,enemy3bullet.transform.forward));
		}
	}
}
