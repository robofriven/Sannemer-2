using UnityEngine;
using System.Collections.Generic;

public class Deck
{

    // Pull the constant from the GameController.  (If it is to be added to/subtracted from than here it would be +3 or -2 or whatever)
    private int maxSize = GameController.MAX_DECK_SIZE;

    public int size {get; private set;}
    public List<Card> cards { get; private set; }
    private int attack;
    private int defense;
    private string name;

    public Deck(int size, string name = "Default")
    {
        this.size = size;
        cards = new List<Card>();
        BuildRandomDeck();
    }

    public Deck(List<Card> cards)
    {
        this.size = cards.Count;
        this.cards = cards;
        
    }

    // Builds a deck filled with random cards.
    private void BuildRandomDeck()
    {
        for (int i = 0; i < size; i++)
        {
            attack = (int) Random.Range(1f, 10f);
            defense = (int)Random.Range(1f, 10f);
            cards.Add(new Card(attack, defense));
        }

    }

    public Card TakeTopCard()
    {
        if (cards.Count > 0)
        {
            var topCard = cards[0];
            cards.Remove(cards[0]);
            return topCard;
        }
        else
        {
            System.Console.Write("There are no more cards in the deck");
            return null;
        }
    }



	
}
