using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class NoteMove : MonoBehaviour {

	public float noteSpeed;
	public KeyCode tocaNota;
	public float fimdatela = -9; // Posicao para deletar a nota
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(-noteSpeed, 0f, 0f) * Time.fixedDeltaTime;
		if (transform.position.x < fimdatela)
		{
			DestroyNote();
		}
	}
	public void DestroyNote() {
		Object.Destroy(gameObject);
	}
}
