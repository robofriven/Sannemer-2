using UnityEngine;
using System.Collections;

public class RoundController : MonoBehaviour
{

    private Dealer Dealer;
    public static int ROUND { get; private set; }


    void Start ()
    {
        ROUND = 0;
        Dealer = GameController.Dealer;
    }


}
