using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour {

	// Use this for initialization
	void Start ()

    {

        GameController.Dealer.Deal();

        print("Hand One:");
        foreach (var card in GameController.Dealer.handOne)
        {
            print(card);
        }
        print("Deck One has " + GameController.Dealer.deckOne.cards.Count + " cards in it");

        //print("Hand Two:");
        //foreach (var card in dealer.handTwo)
        //{
        //    print(card);
        //}

        //foreach (var card in deck.cards)
        //{
        //    print(card);
        //}

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
