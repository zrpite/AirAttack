using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroShoot : MonoBehaviour {

	public GameObject herobullet;
	protected Transform m_transform;
	protected AudioSource au;
	public AudioClip shoot;
	public Vector3 pos;
	public float shootspeed = 0.3f;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		au = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		shootspeed -= Time.deltaTime;
		if(shootspeed <= 0){
				shootspeed = 0.3f;
				pos = new Vector3(m_transform.position.x,m_transform.position.y,0);
				Instantiate(herobullet,pos,m_transform.rotation);
				au.PlayOneShot(shoot);
		}
	}
}
