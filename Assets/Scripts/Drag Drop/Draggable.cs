using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    [System.NonSerialized] public Transform parentToReturnTo = null;


    private Attack attackSpace;
    private Defense defenseSpace;
    private Transform mainCanvas;
    private CanvasGroup canGroup;


    void Start()
    {
        canGroup = GetComponent<CanvasGroup>();
        attackSpace = GameObject.FindGameObjectWithTag("Attack Space").GetComponent<Attack>();
        defenseSpace = GameObject.FindGameObjectWithTag("Defense Space").GetComponent<Defense>();
        mainCanvas = GameObject.FindGameObjectWithTag("Main Canvas").transform;

    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        // Save the original parent (in case of improper drop) and parent to main canvas
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(mainCanvas);
        canGroup.blocksRaycasts = false;                                    // Block raycasts so that the mouse knows where it's at through card

        // If the parentToReturnTo is the attack or defense spot then clear the attack or defense values
        if (parentToReturnTo == attackSpace.transform)
        {
            attackSpace.attackValue = -500;
        }
        else if ( parentToReturnTo == defenseSpace.transform )
        {
            defenseSpace.defenseValue = -500;
        }

    }

    public void OnDrag(PointerEventData eventData)
    {
        // eventData.position is where the mouse cursor is
        this.transform.position = eventData.position;
        

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // When done dragging return to parentToReturnTo (this is changed by the drop zone to itself if valid drop)
        this.transform.SetParent(parentToReturnTo);
        canGroup.blocksRaycasts = true;                                     // Allow the mouse to "see" it again

    }

}
