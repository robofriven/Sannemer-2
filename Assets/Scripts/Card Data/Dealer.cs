using UnityEngine;
using System.Collections.Generic;

public class Dealer
{
    public List<Card> handOne { get; private set; }
    public List<Card> handTwo { get; private set; }

    private static bool dealerExists = false;

    public Deck deckOne{ get; private set; }
    public Deck deckTwo { get; private set; }


    public Dealer(Deck deckOne = null, Deck deckTwo = null)
    {
        if (dealerExists)
        {
            Debug.LogError("Dealer already exists, there can only be one dealer");
            return;
        }

        dealerExists = true;

        // if Deck's are null then create random decks for them
        if (deckOne == null)
        {
            deckOne = new Deck(30);
            deckTwo = new Deck(30);
        }

        this.deckOne = deckOne;
        this.deckTwo = deckTwo;

        // Create new hands for the players or clear the ones already there
        handOne = new List<Card>();
        handTwo = new List<Card>();
    }

    /// <summary>
    /// Deals the amount of cards given, if none specified then the Starting Hand Size is used
    /// </summary>
    /// <param name="amount"></param>
    public void Deal(int amount = GameController.STARTING_HAND_SIZE)
    {
        for (int i = 0; i < amount; i++)
        {
            handOne.Add(deckOne.TakeTopCard());
            handTwo.Add(deckTwo.TakeTopCard());
        }
        
    }
    /// <summary>
    /// Deals the amount of cards given to the player specified
    /// </summary>
    /// <param name="playerNumber"></param>
    /// <param name="amount"></param>
    public void Deal(int playerNumber, int amount)
    {
        // TODO Deal function to give X cards to Y player
        
    }

    // TODO Make the Shuffle function with an existing deck
    // "Shuffles" the deck by building a new deck with the same cards but in a random order
    public Deck Shuffle(Deck deck)
    {

        return new Deck(deck.size);

    }
}
