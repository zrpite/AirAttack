using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroReBirth : MonoBehaviour {

	protected Transform m_transform;
	public BoxCollider2D wallunder;
	protected HeroManager state;
	private Vector3 target;
	protected Animator animate;
	public float speed = 2;

	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		state = this.GetComponent<HeroManager>();
		animate = this.GetComponent<Animator>();
		m_transform.position = new Vector2(0 , -5.6f);
		wallunder.enabled = false;
		target = new Vector2(0,-4);
		state.isBirth = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(state.isBirth){
			animate.SetBool("HeroBirth",true);
		m_transform.position = Vector2.MoveTowards(
								m_transform.position,
								target,
								speed*Time.deltaTime);
	}
		if(m_transform.position == target){
			print("arrived");
			state.isBirth = false;
			state.controlable = true;
			wallunder.enabled = true;
			animate.SetBool("HeroBirth",false);
		}
	}
}
