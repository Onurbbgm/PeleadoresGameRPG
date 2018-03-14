using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AttackManager  : MonoBehaviour {

   

    private Button[] attackButtons;
    private Text[] attackTexts;
    private Text attackDescriptionText; 
    

    // Use this for initialization
    void Start () {
        attackButtons = GetComponentsInChildren<Button>();
        print(attackButtons[0]);
        attackTexts = GetComponentsInChildren<Text>();        
        //print(attackTexts[0].text);
        SetAttackCostDisplay();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPointerEnter(PointerEventData eventData)
    {

    }
    
    void SetAttackCostDisplay()
    {
        int index = 0;
        foreach(Text attackText in attackTexts)
        {            
            if(attackText.tag == "AttackCost")
            {
                Attack specifcAttack = attackButtons[index].GetComponent<Attack>();
                attackText.text = specifcAttack.GetAttackCost().ToString() + " mana\n"+
                    specifcAttack.GetAttackDamage().ToString()+" damage";
                index++;
            }
        }
    }



}
