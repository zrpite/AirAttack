using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonClick : MonoBehaviour {

	private AudioSource button;
	// Use this for initialization
	void Start () {
		button = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClicked(){
		button.Play();
		//SceneManager.LoadScene("GameScene");
		//此处注释因设置了UIRoot为DontDestoryOnLoad,替代一下协程
		StartCoroutine(Wait(0.2f));
	}
	
	IEnumerator Wait(float t){
		yield return new WaitForSeconds(t);
		Application.LoadLevel("GameScene");
	}
}
