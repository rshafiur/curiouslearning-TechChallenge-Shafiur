using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class LightBulb : MonoBehaviour {

    public Sprite bulbOnSprite;

    public void SpriteChange()
    {
        GetComponent<Image>().sprite = bulbOnSprite;
    }
}
