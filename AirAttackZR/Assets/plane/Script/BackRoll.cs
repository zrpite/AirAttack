using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackRoll : MonoBehaviour {

	public float speed = 4;
	protected Transform m_transform;
	private float  Y;
	private Vector3 pos;
	// Use this for initialization
	void Start () {
		m_transform = this.transform;
		pos = new Vector3(1,4,0);
	}
	
	// Update is called once per frame
	void Update () {
		Y = m_transform.localPosition.y;
		if(Y <= -3638)
		{
			m_transform.localPosition = pos;
		}
		m_transform.Translate(new Vector2(0,-speed*Time.deltaTime));
	}
}
