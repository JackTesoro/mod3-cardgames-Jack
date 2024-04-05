using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Golf{
public enum eCardState 
{
    drawpile,
    tableau,
    target,
    discard
}

public class CardGolf : Card
{
    [Header("Set Dynamically: CardGolf")]
    public eCardState           state = eCardState.drawpile;
    public List<CardGolf> hiddenBy = new List<CardGolf>();
    public int                  layoutID;
    public SlotDef              slotDef;
    
    override public void OnMouseUpAsButton() 
    {
        Golf.S.CardClicked(this);
        base.OnMouseUpAsButton();
    }
    }
}

