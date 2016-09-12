using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour
{

    public Attack attackSpace;
    public Defense defenseSpace;
    private RoundController RoundController;

    void Start()
    {
        RoundController = gameObject.GetComponent<RoundController>();
    }

    public void ReadyButtonPushed()
    {
        if (attackSpace.attackValue != -500 && defenseSpace.defenseValue != -500)
        {
            RoundController.Ready(attackSpace.attackValue, defenseSpace.defenseValue);
        }
        else
        {
            Debug.Log("Hey, you have to put a card there first!");
        }
    }

}
