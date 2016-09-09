using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public enum Place
{
    cardArea,
    attackArea,
    defenseArea
}

public class SpriteController : MonoBehaviour
{
    [Header("Card Prefabs")]
    public GameObject cardPrefab;
    public Text attackText;
    public Text defenseText;

    [Header("Screen Areas")]
    //public Canvas mainCanvas;                             // Don't think I need this
    public Transform cardArea;                              // Player's "hand"
    public Transform attackCard;                            // Board area of attack card
    public Transform defenseCard;                           // Board area of defense card


    /// <summary>
    /// Creates the GameObject for the Cards
    /// </summary>
    /// <param name="attack"></param>
    /// <param name="defense"></param>
    /// <param name="place"></param>
    public void DrawCard(int attack, int defense, Place place = Place.cardArea)
    {
        // Probably not going to need this switch, but maybe.
        switch (place)
        {
            case Place.cardArea:
                attackText.text = attack.ToString();
                defenseText.text = defense.ToString();
                GameObject hand = (GameObject)Instantiate(cardPrefab, Vector3.zero, Quaternion.identity);
                hand.transform.SetParent(cardArea.transform);
                hand.GetComponent<CardData>().Attack = attack;
                hand.GetComponent<CardData>().Defense = defense;
                break;
            case Place.attackArea:
                attackText.text = attack.ToString();
                defenseText.text = defense.ToString();
                GameObject att = (GameObject)Instantiate(cardPrefab, Vector3.zero, Quaternion.identity);
                att.transform.SetParent(attackCard.transform);
                att.GetComponent<CardData>().Attack = attack;
                att.GetComponent<CardData>().Defense = defense;
                break;
            case Place.defenseArea:
                attackText.text = attack.ToString();
                defenseText.text = defense.ToString();
                GameObject def = (GameObject)Instantiate(cardPrefab, Vector3.zero, Quaternion.identity);
                def.transform.SetParent(defenseCard.transform);
                def.GetComponent<CardData>().Attack = attack;
                def.GetComponent<CardData>().Defense = defense;
                break;
            default:
                Debug.LogError("WTF MATE??");
                break;
        }

    }



}
