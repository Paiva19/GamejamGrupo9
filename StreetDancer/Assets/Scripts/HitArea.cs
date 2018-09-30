using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitArea : MonoBehaviour {
	public Boolean hasNoteInside;

	public GameObject note;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("StartNote")){return;}
		hasNoteInside = true;
		note = other.gameObject;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		hasNoteInside = false;
		note = null;
	}
}
