using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitNote : MonoBehaviour
{

	public GameObject perfectArea;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (perfectArea.GetComponent<HitArea>().hasNoteInside)
			{
				
				Debug.Log("Apertei alguma coisa");
				Destroy(perfectArea.GetComponent<HitArea>().note);
			}
		}
	}
}
