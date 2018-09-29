using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FighterLife : MonoBehaviour {

    public int fullLife = 100;
    private int life;
    public int fisicalDamage;
    public int musicalDamage;

    public Slider lifeBar;

    private float deltaTime;

    public 
	// Use this for initialization
	void Start () {
        life = fullLife;
        lifeBar.maxValue = fullLife;
        lifeBar.value = fullLife;
	}
	
	// Update is called once per frame
	void Update () {
        deltaTime += Time.deltaTime;
        if (deltaTime > 2)
        {
            getDamaged(10);
            deltaTime = 0f;
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
        this.GetComponent<SpriteRenderer>().color = Color.red;
    }
}
