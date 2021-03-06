﻿using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class DropZone : MonoBehaviour, IDropHandler
{

    public int allowedCards = 20;

    public void OnDrop(PointerEventData eventData)
    {
        var draggedObject = eventData.pointerDrag;

        // Check to see if we're dragging a card (Possibly use Cogs later for this as well
        if (draggedObject.tag == "Card")
        {
            DropCard(draggedObject);
        }
        else
        {
            Debug.LogError("No Card attached to dragged Object");
        }
    }


    //TODO use the max cards allowed to make it so you can't put lots of cards into a spot
    private void DropCard(GameObject draggedCard)
    {
        // Set the parent to link the object being dragged to the drop zone it was dropped on.  Assumes parentToReturnTo exists.

        draggedCard.GetComponent<Draggable>().parentToReturnTo = this.transform;

        var attack = this.GetComponent<Attack>();
        if (attack != null)
        {
            Debug.Log("This is an attack card now");
            attack.attackValue = draggedCard.GetComponent<CardData>().Attack;
        }

        var defend = this.GetComponent<Defend>();
        if (defend != null)
        {
            Debug.Log("This is an Defense card now");
            defend.defenseValue = draggedCard.GetComponent<CardData>().Defense;
        }
    }
}
