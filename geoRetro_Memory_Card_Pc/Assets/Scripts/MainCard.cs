using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCard : MonoBehaviour {

    [SerializeField] private SceneController controller;
    [SerializeField] private GameObject Card_Back;
   

    public void OnMouseDown()
    {
        if (Card_Back.activeSelf && controller.canReveal)
        {
            Card_Back.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    private int _id;
    public int id
    {
        get { return _id; } 
    }

    public void ChangeSprite(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image; // gets sprite renderer and changes the property of the sprite
    }


    public void Unreveal()
    {
        Card_Back.SetActive(true);
    }


}
