using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VitorBehavior : MonoBehaviour {

   
    private Text characterName;
    public Attack[] attacks;   

	// Use this for initialization
	void Start () {            
        characterName = GameObject.Find("CharacterNameText").GetComponent<Text>();
        characterName.text = "Vitor";
       // attacks = GetComponentsInChildren<Attack>();
        SoulSuckerAttack();
        GingerPowerAttack();
        FireCenorinhaAttack();
        RedBloodAttack();
        print(attacks[0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    #region Attacks
    public void SoulSuckerAttack()
    {
        Attack soulSucker = attacks[0];
        soulSucker.SetAttackName("SoulSucker");
        soulSucker.SetAttackCost(20);
        soulSucker.SetAttackDamage(30);
        soulSucker.SetEffect(Attack.AttackEffect.FREZE);
        soulSucker.SetPreparation(0);        
    }

    public void GingerPowerAttack()
    {
        Attack gingerPower = attacks[1];
        gingerPower.SetAttackName("GingerPower");
        gingerPower.SetAttackCost(5);
        gingerPower.SetAttackDamage(15);
        gingerPower.SetEffect(Attack.AttackEffect.NONE);
        gingerPower.SetPreparation(0);
    }

    public void FireCenorinhaAttack()
    {
        Attack fireCenorinha = attacks[2];
        fireCenorinha.SetAttackName("CenorinhaFire");
        fireCenorinha.SetAttackCost(15);
        fireCenorinha.SetAttackDamage(30);
        fireCenorinha.SetEffect(Attack.AttackEffect.FIRE);
        fireCenorinha.SetPreparation(0);
    }

    public void RedBloodAttack()
    {
        Attack redBlood = attacks[3];
        redBlood.SetAttackName("RedBlood");
        redBlood.SetAttackCost(70);
        redBlood.SetAttackDamage(90);
        redBlood.SetEffect(Attack.AttackEffect.BLEED);
        redBlood.SetPreparation(0);
    }

    //Only available in boss mode when is the enemy(not playable)
    public void RedGodAttack()
    {
        Attack redGod = attacks[4];
        redGod.SetAttackName("Red GOD");
        redGod.SetAttackCost(50);
        redGod.SetAttackDamage(130);
        redGod.SetEffect(Attack.AttackEffect.NONE);
        redGod.SetPreparation(2);
    }

    #endregion
}
