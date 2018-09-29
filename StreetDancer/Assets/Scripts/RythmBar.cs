using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RythmBar : MonoBehaviour {
	public float bpm; // bpm da música, batimentos por minuto
	public float noteSpeed; // velocidde que a nota vai em direcao da caixa de hit da nota
	public GameObject novaNota; // objeto nota 
	private float deltaTime; // tewmpo entre a ultima nota gerada e tempo atual
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		deltaTime += Time.deltaTime;
		if(deltaTime >= 60/bpm){
			deltaTime = 0;
			var nota = GameObject.Instantiate(novaNota);
			nota.GetComponent<NoteMove>().noteSpeed = this.noteSpeed;
		}
	}
}
