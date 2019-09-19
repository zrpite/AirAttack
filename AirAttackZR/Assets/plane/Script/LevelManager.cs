using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	protected UILabel score; 
	public GameObject enemy2spawn,enemy3spawn,enemy3left,enemy3right;
	// Use this for initialization
	void Start () {
		score = GameObject.Find("Score").GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {
		if(int.Parse(score.text) >= 1000){
			enemy2spawn.SetActive(false);
			enemy3spawn.SetActive(true);
			enemy3left.SetActive(true);
			enemy3right.SetActive(true);
		}
	}
}
