using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OverOnClickBack : MonoBehaviour {

	private AudioSource au;
	// Use this for initialization
	void Start () {
		au = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClicked(){
		au.Play();
		StartCoroutine(Wait(0.3f));
	}
	IEnumerator Wait(float t){
		yield return new WaitForSeconds(t);
		SceneManager.LoadScene("PreLoadScene");
	}
}
