using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private CanvasGroup canGroup;
    void Start()
    {
        canGroup = GetComponent<CanvasGroup>();
    }

    public Transform parentToReturnTo = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        print("OnBeginDrag");
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(transform.parent.parent);
        canGroup.blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        // eventData.position is where the mouse cursor is
        this.transform.position = eventData.position;
        

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(parentToReturnTo);
        canGroup.blocksRaycasts = true;

    }

}
