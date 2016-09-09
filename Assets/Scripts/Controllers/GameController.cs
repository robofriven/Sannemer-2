using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour

{
    // Initialization Constants
    public const int STARTING_HP = 20;
    public const int SCORE_GOAL = 20;
    public const int STARTING_HAND_SIZE = 7;
    public const int MAX_HAND_SIZE = 10;
    // public const minDeckSize = Whatever Min Decksize will be
    public const int MAX_DECK_SIZE = 30;


    // Game Controllers, etc
    public static Dealer Dealer;

    // Player Variables

    private static int PLAYER_ONE_HP = STARTING_HP;
    private static int PLAYER_TWO_HP = STARTING_HP;
    private static int PLAYER_ONE_SCORE = 0;
    private static int PLAYER_TWO_SCORE = 0;


    void Start()
    {
        Dealer = new Dealer();
    }

    // Get player's health (-100 means there was an error)
    public static int GetHealth(int playerNumber)
    {
        if (playerNumber == 1)
        {
            return PLAYER_ONE_HP;
        }
        else if (playerNumber == 2)
        {
            return PLAYER_TWO_HP;
        }
        else
        {
            Debug.LogError("Incorrect Player Number Given");
            return -100;
        }
    }

    // Get player's Score (-100 means there was an error)
    public static int GetScore(int playerNumber)
    {
        if (playerNumber == 1)
        {
            return PLAYER_ONE_SCORE;
        }
        else if (playerNumber == 2)
        {
            return PLAYER_TWO_SCORE;
        }
        else
        {
            Debug.LogError("Incorrect Player Number Given");
            return -100;
        }
    }


    // Change the player's Health (Negative number to heal)
    public static void DoDamage(int playerNumber, int damageAmount)
    {
        if (playerNumber == 1)
        {
            PLAYER_ONE_HP -= damageAmount;
        }
        else if( playerNumber == 2)
        {
            PLAYER_TWO_HP -= damageAmount;
        }
        else
        {
            Debug.LogError("Incorrect Player Number Given");
        }
    }
	


}
