using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleGun : MonoBehaviour {

	public bool useable = false;
	public float duration = 8;
	protected HeroManager controlshootdown;
	protected GameObject gun;
	// Use this for initialization
	void Start () {
		gun = GameObject.Find("gun1");
		controlshootdown = GameObject.Find("Hero").GetComponent<HeroManager>();
		gun.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(!controlshootdown.controlable){
			useable = false;
		}
		if(!useable){
			gun.SetActive(false);
		}
		if(useable){
			gun.SetActive(true);
			duration -= Time.deltaTime;
			if(duration <= 0){
				duration = 8;
				useable = false;
				gun.SetActive(false);
			}
		}
	}
}
