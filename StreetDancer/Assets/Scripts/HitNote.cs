using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitNote : MonoBehaviour
{

	public GameObject perfectArea;

	public GameObject goodArea;

	public GameObject badArea;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (perfectArea.GetComponent<HitArea>().hasNoteInside)
			{
				Debug.Log("PERFECT");
				Destroy(perfectArea.GetComponent<HitArea>().note);
			}
			else if (goodArea.GetComponent<HitArea>().hasNoteInside)
			{
				Debug.Log("GOOD");
				Destroy(perfectArea.GetComponent<HitArea>().note);
			}
			else if (badArea.GetComponent<HitArea>().hasNoteInside)
			{
				Debug.Log("BAD");
				Destroy(badArea.GetComponent<HitArea>().note);
			}
			else
			{
				Debug.Log("YOU SUCK");
			}
		}
	}
}
