using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

    public enum CharacterStatus { FROZEN, FIRE, BLEEDING, POISON, OK };
    public int health = 100;
    public int mana = 100;
    private CharacterStatus status;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


    }

    public void SetCharacterStatus(CharacterStatus newStatus)
    {
        status = newStatus;
    }

    public CharacterStatus GetCharacterStatus()
    {
        return status;
    }

    public void Damage(int damage)
    {        
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public bool ManaUse(int manaCost)
    {
        if(mana <= 0 || mana < manaCost)
        {
            return false;
        }
        else
        {
            mana -= manaCost;
            return true;
        }        
    }

    public void ManaGain(int manaGain)
    {        
        if (mana <= manaGain)
        {
            mana += manaGain;
        }
        if(mana > 100)
        {
            mana = 100;
        }   
    }

}
