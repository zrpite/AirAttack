using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomControl : MonoBehaviour {
	protected Transform m_transform;
	public float speed = 4;
	protected UILabel boomnum;
	public int numofboom = 0;
	protected AudioSource au;
	public AudioClip getboom;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		m_transform.Translate(new Vector2(0,-speed*Time.deltaTime));
		boomnum = GameObject.Find("BoomNum").GetComponent<UILabel>();
		au = this.GetComponent<AudioSource>();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Hero"){
			au.PlayOneShot(getboom);
			StartCoroutine(Wait(0.1f));
			Destroy(this.gameObject,1);
			numofboom = int.Parse(boomnum.text);
			numofboom += 1;
			boomnum.text = numofboom.ToString();
		}
	}
	IEnumerator Wait(float t){
		yield return new WaitForSeconds(t);
		this.GetComponent<SpriteRenderer>().enabled =false;
		this.GetComponent<BoxCollider2D>().enabled =false;
	}
}
