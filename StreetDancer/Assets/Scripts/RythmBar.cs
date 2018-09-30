using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class RythmBar : MonoBehaviour {
	public float bpm = 95; // bpm da música, batimentos por minuto
	public float noteSpeed = 4; // velocidde que a nota vai em direcao da caixa de hit da nota
	public GameObject newNota; // objeto nota
	public float notePosition = 9;
	private float deltaTime; // tempo entre a ultima nota gerada e tempo atual
	public int offset;
	public bool first = true;
	
	// Update is called once per frame
	private void Update () {
        deltaTime += Time.deltaTime;
	    if(deltaTime >= 60/bpm)
	    {
		    CreateNote();
		    if (first)
		    {
			    CreateMusicStarter();
			    first = false;
		    }
	    	
	    }
	}
	private void CreateNote()
	{
		deltaTime = 0;
		var note = GameObject.Instantiate(newNota);
		note.GetComponent<Transform>().localPosition = GetComponent<Transform>().position + new Vector3(notePosition, 0, 0);
		note.GetComponent<NoteMove>().noteSpeed = this.noteSpeed;
			
	}

	private void CreateMusicStarter()
	{
		deltaTime = offset / bpm;
		var startnote = GameObject.Instantiate(newNota);
		startnote.tag = "StartNote";
		startnote.layer = 9;
		startnote.GetComponent<SpriteRenderer>().color = Color.clear;
		startnote.GetComponent<Transform>().localPosition = GetComponent<Transform>().position + new Vector3(notePosition, 0, 0);
		startnote.GetComponent<NoteMove>().noteSpeed = this.noteSpeed;
	}
}
