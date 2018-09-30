using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMusic : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.Find("RythmBars").GetComponent<AudioSource>().enabled = true;
    }
}
