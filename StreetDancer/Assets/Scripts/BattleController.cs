using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    public int p1Wins = 0;
    public int p2Wins = 0;
	
	// Update is called once per frame
	void Update () {
		if (p1Wins > 1)
        {
            player1.GetComponent<FighterLife>().enabled = false;
            player1.GetComponent<FighterStrike>().enabled = false;
            player2.GetComponent<FighterLife>().enabled = false;
            player2.GetComponent<FighterStrike>().enabled = false;
            Debug.Log("p1 Wins");
        }
        else if (p2Wins > 1)
        {
            player1.GetComponent<FighterLife>().enabled = false;
            player1.GetComponent<FighterStrike>().enabled = false;
            player2.GetComponent<FighterLife>().enabled = false;
            player2.GetComponent<FighterStrike>().enabled = false;
            Debug.Log("p2 Wins");
        }
	}

    public void Win(GameObject winningPlayer)
    {
        if (winningPlayer.name.Equals(player1.name)){
            p1Wins++;
            Debug.Log("p1");
        }
        else
        {
            p2Wins++;
            Debug.Log("p2");
        }
    }
}
