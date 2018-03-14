using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour {

    public enum AttackEffect { FREZE, FIRE, POISON, BLEED, NONE };

    private Text attackTextDisplay;
    private int attackCost;
    private string attackName;
    private int attackDamage;
    private AttackEffect attackEffect;
    private int attackPreparation; //number of turns to prepare attack

    // Use this for initialization
    void Start () {
        attackTextDisplay = GetComponentInChildren<Text>();
        attackTextDisplay.text = attackName;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetAttackCost(int cost)
    {
        attackCost = cost;
    }

    public void SetAttackName(string name)
    {
        attackName = name;
    }

    public void SetAttackDamage(int damage)
    {
        attackDamage = damage;
    }

    public void SetEffect(AttackEffect effect)
    {
        attackEffect = effect;
    }

    public void SetPreparation(int turns)
    {
        attackPreparation = turns;
    }

    public int GetAttackCost()
    {
        return attackCost;
    }

    public int GetAttackDamage()
    {
        return attackDamage;
    }

    public string GetAttackName()
    {
        return attackName;
    }

    public AttackEffect GetEffect()
    {
        return attackEffect;
    }

    public int GetPreparation()
    {
        return attackPreparation;
    }


}
