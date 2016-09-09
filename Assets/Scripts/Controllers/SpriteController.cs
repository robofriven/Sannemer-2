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



    public void DrawCard(int attack, int defense, Place place)
    {
        switch (place)
        {
            case Place.cardArea:
                attackText.text = attack.ToString();
                defenseText.text = defense.ToString();
                GameObject hand = (GameObject)Instantiate(cardPrefab, Vector3.zero, Quaternion.identity);
                hand.transform.SetParent(cardArea.transform);
                break;
            case Place.attackArea:
                attackText.text = attack.ToString();
                defenseText.text = defense.ToString();
                GameObject att = (GameObject)Instantiate(cardPrefab, Vector3.zero, Quaternion.identity);
                att.transform.SetParent(attackCard.transform);
                break;
            case Place.defenseArea:
                attackText.text = attack.ToString();
                defenseText.text = defense.ToString();
                GameObject def = (GameObject)Instantiate(cardPrefab, Vector3.zero, Quaternion.identity);
                def.transform.SetParent(defenseCard.transform);
                break;
            default:
                Debug.LogError("WTF MATE??");
                break;
        }

    }



}
