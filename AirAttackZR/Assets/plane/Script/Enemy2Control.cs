using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Control : MonoBehaviour {
	public float speed = 1;
	public float live = 10;
	public int grade = 50;
	public int numofscore;
	protected Transform m_transform;
	protected Animator animate;
	protected AudioSource au;
	public AudioClip boom;
	protected UILabel score;
	private Vector2 target;

	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		animate = this.GetComponent<Animator>();
		au = this.GetComponent<AudioSource>();
		score = GameObject.Find("Score").GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
		if(live > 0){
			target = new Vector2(m_transform.position.x,2.32f);
		m_transform.position = Vector2.MoveTowards(
								m_transform.position,
								target,
								speed*Time.deltaTime);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Boom" || other.tag == "Hero"){
			live -= 50;
		}
		if(other.tag == "HeroBullet"){
			live -= 1;
			animate.SetBool("Hit",true);
			StartCoroutine(Wait(0.1f));
		}
		judgeLive();
	}
	IEnumerator Wait(float t){
		yield return new WaitForSeconds(t);
		animate.SetBool("Hit",false);
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
			animate.SetBool("Boom",true);
			this.GetComponent<CapsuleCollider2D>().enabled = false;
			this.GetComponent<Enemy2Shoot>().enabled = false;
			Destroy(this.gameObject,1);
		}
	}
}
