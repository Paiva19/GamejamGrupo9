using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HitNote : MonoBehaviour
{

	public GameObject perfectArea;
    public GameObject goodArea;
    public GameObject badArea;

    public GameObject player;
    public GameObject targetPlayer;

	public GameObject Toot;
    //public float distance;

    public List<KeyCode> keyCodes;
	
	private Random rnd = new Random();
	private AudioSource[] frases;

	void Start()
	{
		frases = Toot.GetComponents<AudioSource>();

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

		if (hit && player.GetComponent<FighterStrike>().alive && targetPlayer.GetComponent<FighterLife>().alive)
		{
			switch (hitKey)
			{
				//Música
				case 1:
					frases[Random.Range(0, 3)].Play();
					break;
				case 3:
					frases[Random.Range(4, 7)].Play();
					break;
				default:
					frases[Random.Range(8,11)].Play();
					break;
			}

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
                RaycastHit2D rayHit = Physics2D.Raycast(transform.position, Vector2.right, 7f, 9);
                if (rayHit.collider != null && !rayHit.collider.CompareTag("StartNote"))
                {
                    player.GetComponent<FighterStrike>().Strike(hitKey, 0);
                    Destroy(rayHit.collider.gameObject);
                };
                //Debug.Log("YOU SUCK");
            }
		}
	}
}
