using UnityEngine;
using System.Collections.Generic;

public class RoundController : MonoBehaviour
{
    // Public properties
    public static int ROUND { get; private set; }

    // Public variables
    public SpriteController spriteController;

    // Private variables
    private Dealer Dealer;
    private int attack1;
    private int attack2;
    private int defense1;
    private int defense2;
    private bool PlayerOneReady = false;
    private bool PlayerTwoReady = false;                             // This will be used for multiplayer mode


    void Start ()
    {
        ROUND = 0;
        Dealer = GameController.Dealer;
        Dealer.Deal();

        foreach (var card in Dealer.handOne)
        {
            spriteController.DrawCard(card.attack, card.defense, Place.cardArea);
        }
    }

    public void Ready(int attack, int defense)
    {
        this.attack1 = attack;
        this.defense1 = defense;

        PlayerOneReady = true;
        PlayerTwoReady = true;                                      // HACK Fix this so multiplayer will work
    }

    void Update()
    {
        if (PlayerOneReady && PlayerTwoReady)
        {
            Debug.Log("Both players are Ready!");
            PlayerOneReady = false;
            PlayerTwoReady = false;
        }
    }


}
