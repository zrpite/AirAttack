using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Control : MonoBehaviour {
	public float speed = 1;
	public float live = 1;
	public int grade = 10;
	public int numofscore;
	protected Transform m_transform;
	protected Animator animate;
	protected AudioSource au;
	public AudioClip boom;
	protected UILabel score;

	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		animate = this.GetComponent<Animator>();
		au = this.GetComponent<AudioSource>();
		score = GameObject.Find("Score").GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
		if(live > 0)
		m_transform.Translate(new Vector2(0,-speed*Time.deltaTime));
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "HeroBullet"
		||other.tag == "Hero"
		||other.tag == "Boom"){
			live -= 50;
		}
		if(other.tag.CompareTo("WallUnder")==0)
			Destroy(this.gameObject,0.6f);
			judgeLive();
	}
	void addScore(){
		numofscore = int.Parse(score.text);
		numofscore += grade;
		score.text = numofscore.ToString();
	}
	void judgeLive(){
		if(live <= 0){
			addScore();
			au.PlayOneShot(boom);
			animate.SetBool("Enemy1Boom",true);
			this.GetComponent<BoxCollider2D>().enabled = false;
			this.GetComponent<Enemy1Shoot>().enabled = false;
			Destroy(this.gameObject,1);
		}
	}
}
