using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitStart : MonoBehaviour
{


	public GameObject coisoComSom;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("StartNote"))
		{
			coisoComSom.GetComponent<AudioSource>().enabled = true;
		}
	}
}
