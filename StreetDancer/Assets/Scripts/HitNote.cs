using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitNote : MonoBehaviour
{

	public GameObject perfectArea;
    public GameObject goodArea;
    public GameObject badArea;

    public GameObject player;
	
    public List<KeyCode> keyCodes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        bool hit = false;
		int hitKey = 0;
        foreach (KeyCode key in keyCodes)
        {
            hit = Input.GetKeyDown(key);
            if (hit)
            {
                hitKey = keyCodes.IndexOf(key) + 1;
                break;
            }
        }
		if (hit)
		{
			if (perfectArea.GetComponent<HitArea>().hasNoteInside)
			{
				//Debug.Log("PERFECT " + hitKey.ToString());
                player.GetComponent<FighterStrike>().Strike(hitKey, 3);
				Destroy(perfectArea.GetComponent<HitArea>().note);
			}
			else if (goodArea.GetComponent<HitArea>().hasNoteInside)
			{
				//Debug.Log("GOOD " + hitKey.ToString());
                player.GetComponent<FighterStrike>().Strike(hitKey, 2);
                Destroy(goodArea.GetComponent<HitArea>().note);
			}
			else if (badArea.GetComponent<HitArea>().hasNoteInside)
			{
				//Debug.Log("BAD " + hitKey.ToString());
                player.GetComponent<FighterStrike>().Strike(hitKey, 1);
                Destroy(badArea.GetComponent<HitArea>().note);
			}
			else
			{
                player.GetComponent<FighterStrike>().Strike(1, 0);
                //Debug.Log("YOU SUCK");
			}
		}
	}
}
