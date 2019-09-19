using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy3Control : MonoBehaviour {

	
	public float speed = 1;
	public float live = 300;
	public int grade = 500;
	public int numofscore;
	public Enemy3Bullet enemy3bullet;
	protected Transform m_transform;
	protected Animator animate;
	protected AudioSource au;
	public AudioClip boom;
	protected UILabel score;
	private Vector2 target,start;

	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		animate = this.GetComponent<Animator>();
		au = this.GetComponent<AudioSource>();
		score = GameObject.Find("Score").GetComponent<UILabel>();
		start = new Vector2(0,5.52f);
	}
	
	// Update is called once per frame
	void Update () {
		if(live > 0){
		target = new Vector2(m_transform.position.x,1.91f);
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
			this.GetComponent<PolygonCollider2D>().enabled = false;
			this.GetComponent<Enemy3Shoot>().enabled = false;
			Global.achievement = true;
			StartCoroutine(Wait2(1.5f));
		}
	}
	IEnumerator Wait2(float t){
			yield return new WaitForSeconds(t);
			SceneManager.LoadScene("OverScene");
		}
}
