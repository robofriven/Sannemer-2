using UnityEngine;
using System.Collections.Generic;

public class RoundController : MonoBehaviour
{
    public SpriteController spriteController;

    private Dealer Dealer;
    public static int ROUND { get; private set; }


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


}
