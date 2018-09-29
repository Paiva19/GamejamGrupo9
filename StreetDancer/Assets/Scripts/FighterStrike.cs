using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterStrike : MonoBehaviour
{
	public int baseDamage; //Dano base que o golpe causa
	public GameObject targetPlayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Strike(/*int atk,*/ int perfection)
	// atk = numero do ataque utilizado, perfection: 0 = miss, 1 = bad, 2 = good, 3 = perfect
	{
		//Calcula dano do ataque e aplica no adversario
		int atkDamage;
		atkDamage = baseDamage * perfection / 3;
		targetPlayer.GetComponent<FighterLife>().getDamaged(atkDamage);
	}
}
