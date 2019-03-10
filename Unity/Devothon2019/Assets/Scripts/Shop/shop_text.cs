using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop_text : MonoBehaviour
{
    public Text money;

    public Text upgradeCoque;
    public Text repairCoque;
    public Text addCrewMember;
    
    public Text changeType;
    public Text upgradeCanon;

    public Dropdown ddl_typeCanon;

    private void Start() {
        upgradeCoque.text = "Améliorer la coque (" + price.UPGRADE_COQUE + "$)";
        repairCoque.text = "Réparer la coque (" + price.REPAIR_COQUE + "$)";
        upgradeCanon.text = "Améliorer le canon (" + price.UPGRADE_CANON + "$)";
    }

    private void Update() {
        CanonType newType = (CanonType)ddl_typeCanon.value;
        int cost = 0;

        switch(newType)
        {
            case CanonType.LanceFlammes:
                cost = price.CANON_FLAME;
                break;
            case CanonType.Normal:
                cost = price.CANON_NORMAL;
                break;
            case CanonType.TirTriple:
                cost = price.CANON_TRIPLE;
                break;
            default:
                cost = 40;
                break;
        }

        changeType.text = "Changer type (" + cost + "$)";

        addCrewMember.text = "Ajouter un membre à l'équipage\n("+PlayerInstance.playerStats.crewMembers+" présentement) ("+price.ADD_CREW+"$)";
        money.text = "Banque : " + PlayerInstance.playerCash + "$";
    }

}