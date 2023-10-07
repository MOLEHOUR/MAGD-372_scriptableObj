using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card Card;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public Image artworkImage;
    void Start()
    {
        Card.Print();
        artworkImage.sprite = Card.artwork;
        nameText.text = Card.cardName;
        descriptionText.text = Card.description;
        

    }       
}
