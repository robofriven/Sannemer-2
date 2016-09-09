using UnityEngine;
using System.Collections;

public class Card
{

    // Card Stat variables
    private int attack;
    private int defense;


    // Add in special Abilities

    public Card(int att, int def)
    {
        this.attack = att;
        this.defense = def;
    }

    public override string ToString()
    {
        return string.Format("Attack - {0}, Defense - {1}", attack, defense);
    }

}
