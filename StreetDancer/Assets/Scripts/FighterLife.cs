using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FighterLife : MonoBehaviour {

    public int fullLife = 100;
    private int life;

    public Slider lifeBar;

    public 
	// Use this for initialization
	void Start () {
        life = fullLife;
        lifeBar.maxValue = fullLife;
        lifeBar.value = fullLife;
	}
	
	// Update is called once per frame
	void Update () {
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
        
        GameObject.Destroy(GetComponent<FighterStrike>());
        this.GetComponent<SpriteRenderer>().color = Color.red;
    }
}
