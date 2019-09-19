using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickCallBack : MonoBehaviour {

	protected AudioSource au;
	public GameObject pause;
	// Use this for initialization
	void Start () {
		au = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClicked(){
		au.Play();
		Time.timeScale = 1;
		StartCoroutine(Wait(0.2f));
	}
	IEnumerator Wait(float t){
		yield return new WaitForSeconds(t);
		this.gameObject.SetActive(false);
		pause.SetActive(true);
	}
}
