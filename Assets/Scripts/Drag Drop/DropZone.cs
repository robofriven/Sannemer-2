using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class DropZone : MonoBehaviour, IDropHandler
{

    public int allowedCards = 20;

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("On Drop");

        // Set the parent to link the object being dragged to the drop zone it was dropped on.  Assumes parentToReturnTo exists.
        eventData.pointerDrag.GetComponent<Draggable>().parentToReturnTo = this.transform;

    }
}
