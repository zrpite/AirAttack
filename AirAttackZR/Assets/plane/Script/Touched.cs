using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touched : MonoBehaviour {
	public float speed = 0.1f;
	protected HeroManager able;
	private Vector3 pos;
    void Start () {
		able = this.GetComponent<HeroManager>();
    }
	
	// Update is called once per frame
	void Update () {
         if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) { 
			 pos = new Vector3(Input.GetTouch(0).position.x,Input.GetTouch(0).position.y+100,0);
		   if(able.controlable&&Time.timeScale != 0)
		  	 transform.position = Camera.main.ScreenToWorldPoint(pos);
        }  
	}
}
