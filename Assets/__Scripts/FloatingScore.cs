using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum FSState{
	idle,
	pre,
	active,
	post
}

public class FloatingScore : MonoBehaviour {
	public FSState		state = FSState.idle;
	[Serialize Field]
	private internal	_score = 0;
	public string		scoreString;

	public int score{
		get{
			return(_score);
		}
		set{
			_score = value;
			scoreString = Utils.AddCommasToNumber(_score);
			GetComponent<GUIText>().text = scoreString;
		}
	}

	//!!!!!!!!!!!!!!!!  START HERE  !!!!!!!!!!!!!!!!!!

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
