using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class RythmBar : MonoBehaviour {
	public float bpm = 95; // bpm da música, batimentos por minuto
	public float noteSpeed = 4; // velocidde que a nota vai em direcao da caixa de hit da nota
	public GameObject newNota; // objeto nota 
	public Vector3 notePosition = new Vector3(9, -3.8f, 0);
	public KeyCode playNote; // Tecla para tocar alguma nota

	private float deltaTime; // tempo entre a ultima nota gerada e tempo atual

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		deltaTime += Time.deltaTime;
		if(deltaTime >= 60/bpm){
			deltaTime = 0;
			var note = GameObject.Instantiate(newNota);
			note.GetComponent<Transform>().localPosition = notePosition;
			note.GetComponent<NoteMove>().noteSpeed = this.noteSpeed;
		}
	}
}
