using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FighterLife : MonoBehaviour {

    public int fullLife = 100;
    public bool alive = true;
    public bool revivendo = false;

    public float FadeRate;

    public KeyCode mainKey;
    public Slider lifeBar;
    public GameObject targetPlayer;
    public GameObject playersController;

    public GameObject rythmBars;

    private int life;

    public 
	// Use this for initialization
	void Start () {
        life = fullLife;
        lifeBar.maxValue = fullLife;
        lifeBar.value = fullLife;
	}
	
	// Update is called once per frame
	void Update () {
        if (revivendo)
        {
            Color curColor = this.GetComponent<SpriteRenderer>().color;
            int lifeDiff = Mathf.Abs(fullLife - life);
            if (lifeDiff > 0)
            {
                curColor.g = Mathf.Lerp(curColor.g, 1f, this.FadeRate * Time.deltaTime);
                curColor.b = Mathf.Lerp(curColor.b, 1f, this.FadeRate * Time.deltaTime);
                this.GetComponent<SpriteRenderer>().color = curColor;
                life = Convert.ToInt32(Math.Ceiling(Mathf.Lerp(life, fullLife, this.FadeRate * Time.deltaTime)));
                lifeBar.value = life;
            }
            else
            {
                revivendo = false;
                revive();
            }
        }
        else if (!alive)
        {
            if (Input.GetKeyDown(mainKey))
            {
                revivendo = true;
                targetPlayer.GetComponent<FighterLife>().revivendo = true;
            }
        }
    }

    public void getDamaged(int damage)
    {
        this.life -= damage;
        lifeBar.value = life;
        if (life <= 0)
        {
            die();
        }
    }

    public void die()
    {
        playersController.GetComponent<BattleController>().Win(targetPlayer);
        alive = false;
        GetComponent<FighterStrike>().alive = false;
        GetComponent<SpriteRenderer>().color = Color.red;
        rythmBars.GetComponent<RythmBarsController>().disable();
    }

    public void revive()
    {        
        alive = true;
        GetComponent<FighterStrike>().alive = true;
        rythmBars.GetComponent<RythmBarsController>().enable();
    }
}
