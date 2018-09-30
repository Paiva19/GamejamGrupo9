﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BattleController : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;

    public int p1Wins = 0;
    public int p2Wins = 0;

    public Image p1v1;
    public Image p1v2;
    public Image p2v1;
    public Image p2v2;

    public Image winner;

    public Sprite p1Winner;
    public Sprite p2Winner;

    // Update is called once per frame
    void Update () {
        if (p1Wins > 1 || p2Wins > 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
        }
		if (p1Wins > 1)
        {
            player1.GetComponent<FighterLife>().enabled = false;
            player1.GetComponent<FighterStrike>().enabled = false;
            player2.GetComponent<FighterLife>().enabled = false;
            player2.GetComponent<FighterStrike>().enabled = false;
            winner.sprite = p1Winner;
            winner.color = Color.white;
            //Debug.Log("p1 Wins");
        }
        else if (p2Wins > 1)
        {
            player1.GetComponent<FighterLife>().enabled = false;
            player1.GetComponent<FighterStrike>().enabled = false;
            player2.GetComponent<FighterLife>().enabled = false;
            player2.GetComponent<FighterStrike>().enabled = false;
            winner.sprite = p2Winner;
            winner.color = Color.white;
            //Debug.Log("p2 Wins");
        }

 
	}

    public void Win(GameObject winningPlayer)
    {
        if (winningPlayer.name.Equals(player1.name)){
            if (p1Wins == 0)
            {
                p1v1.color = Color.red;
            }
            else
            {
                p1v2.color = Color.red;
            }
            p1Wins++;
        }
        else
        {
            if (p2Wins == 0)
            {
                p2v1.color = Color.red;
            }
            else
            {
                p2v2.color = Color.red;
            }
            p2Wins++;
        }
    }
}
