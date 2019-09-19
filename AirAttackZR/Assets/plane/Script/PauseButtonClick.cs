using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButtonClick : MonoBehaviour {

	private AudioSource au;
	public GameObject callback;
	// Use this for initialization
	void Start () {
		au = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void OnClicked(){
		au.Play();
		StartCoroutine(Wait(0.2f));
	}
	IEnumerator Wait(float t){
		yield return new WaitForSeconds(t);
		Time.timeScale = 0;
		this.gameObject.SetActive(false);
		callback.SetActive(true);
	}
}

