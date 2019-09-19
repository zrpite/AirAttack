using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasterControl : MonoBehaviour {
	protected Transform m_transform;
	public float speed = 4;
	protected AudioSource au;
	public AudioClip getfaster;
	protected DoubleGun doublegun;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		m_transform.Translate(new Vector2(0,-speed*Time.deltaTime));
		doublegun = GameObject.Find("Hero").GetComponent<DoubleGun>();
		au = this.GetComponent<AudioSource>();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
			if(other.tag == "Hero"){
				au.PlayOneShot(getfaster);
			doublegun.useable = true;
			StartCoroutine(Wait(0.1f));
			Destroy(this.gameObject,1);
		}
	}
		IEnumerator Wait(float t){
		yield return new WaitForSeconds(t);
		this.GetComponent<SpriteRenderer>().enabled =false;
		this.GetComponent<BoxCollider2D>().enabled =false;
	}
}
