using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RythmBarsController : MonoBehaviour {

    public GameObject Bar1;
    public GameObject Bar2;
	public void disable()
    {
        
        GetComponent<AudioSource>().enabled = false;

        Bar1.GetComponent<RythmBar>().enabled = false;
        Bar2.GetComponent<RythmBar>().enabled = false;

        var notes = GameObject.FindGameObjectsWithTag("Note");
        foreach(var note in notes)
        {
            Destroy(note);
        }
    }

    public void enable()
    {
        Bar1.GetComponent<RythmBar>().first = true;
        Bar1.GetComponent<RythmBar>().enabled = true;
        Bar2.GetComponent<RythmBar>().first = true;
        Bar2.GetComponent<RythmBar>().enabled = true;
    }
}
