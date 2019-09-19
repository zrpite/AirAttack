using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaveBoom : MonoBehaviour {
	public GameObject boom;
	protected UILabel snum;
	private int inum;
	// Use this for initialization
	void Start () {
		snum = this.GetComponentInChildren<UILabel>();
		inum = int.Parse(snum.text);
	}
	// Update is called once per frame
	void Update () {
		
	}
	public void OnClicked(){
		inum = int.Parse(snum.text);
		if(inum > 0){
			inum--;
			snum.text = inum.ToString();
			boom.SetActive(true);
			StartCoroutine(Wait(0.1f));
		}
	}
	IEnumerator Wait(float t){
		yield return new WaitForSeconds(t);
		boom.SetActive(false);
	}
}
