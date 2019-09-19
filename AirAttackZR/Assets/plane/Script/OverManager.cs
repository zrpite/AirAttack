using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverManager : MonoBehaviour {
	protected UILabel lastscore,bestscore;
	protected AudioSource au;
	public AudioClip faild;
	public AudioClip win;
	// Use this for initialization
	void Start () {
		au = this.GetComponent<AudioSource>();
		if(Global.achievement){
			au.PlayOneShot(win);
		}
		else{
			au.PlayOneShot(faild);
		}
		lastscore = GameObject.Find("LastScore").GetComponent<UILabel>();
		bestscore =GameObject.Find("BestScore").GetComponent<UILabel>();
		lastscore.text = Global.last();
		bestscore.text = Global.Best();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
