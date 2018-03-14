using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class AttackDescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


    private Text attackDescriptionText;
    private Button[] attackButtons;
    private Attack attack;

    // Use this for initialization
    void Start () {
        attackDescriptionText = GameObject.FindGameObjectWithTag("AttackDescription").GetComponent<Text>();
        if (attackDescriptionText == null)
        {
            Debug.Log("Nao foi");
        }
        attack = GetComponent<Attack>();
        print(attackDescriptionText.text + " teste");
    }
    //attackButtons = GetComponentsInParent<Button>();

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        attackDescriptionText.text = attack.GetAttackCost().ToString() +" cost\n"+ attack.GetAttackDamage().ToString() +" damage\n"+
            attack.GetEffect().ToString() + " efeito";
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        attackDescriptionText.text = "";
    }
}
	
	


