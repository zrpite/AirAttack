using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroManager : MonoBehaviour {
	//玩家命数
	public int life;
	//玩家飞机是否可控制
	public bool controlable = false;
	public AudioClip boom;
	public bool isBirth = false;
	public bool isGod = false;
	protected UILabel score;
	protected Animator animate;
	protected Transform m_transform;
	protected GameObject shootable;
	protected PolygonCollider2D colli;
	protected AudioSource au;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		life = 3;
		animate = this.GetComponent<Animator>();
		shootable = GameObject.Find("gun");
		colli = this.GetComponent<PolygonCollider2D>();
		au = this.GetComponent<AudioSource>();
		score = GameObject.Find("Score").GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
		if(life == 0){
			this.gameObject.SetActive(false);
		}
		
	}		
	void OnTriggerEnter2D(Collider2D other)
	{

		if(other.tag == "Enemy1Bullet"
		 ||other.tag == "Enemy1"
		 ||other.tag == "Enemy2"){
			if(!isGod){
				au.PlayOneShot(boom);
			animate.SetBool("HeroBoom",true);
			controlable = false;
			if(other.tag.CompareTo("Enemy1") != 0)
				Destroy(other.gameObject);
			shootable.SetActive(false);
			colli.enabled =false;
			StartCoroutine(Wait(2));
			}
		}
	}
	
	IEnumerator Wait(float t){
		yield return new WaitForSeconds(t);
		life--;
		if(life == 0){
			Global.lastscore = score.text;
			SceneManager.LoadScene("OverScene");
		}
		m_transform.position = new Vector2(0 , -5.6f);
			shootable.SetActive(true);
			colli.enabled = true;
		isBirth = true;
		animate.SetBool("HeroBoom",false);
		StartCoroutine(Wait2(4));
	}
	IEnumerator Wait2(float t){
		isGod = true;
		yield return new WaitForSeconds(t);
		isGod = false;
	}
}
