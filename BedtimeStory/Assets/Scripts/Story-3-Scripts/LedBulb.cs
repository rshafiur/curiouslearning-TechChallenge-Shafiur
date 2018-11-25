using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class LedBulb : MonoBehaviour {

    public Sprite ledOnSprite;

    public void SpriteChange()
    {
        GetComponent<Image>().sprite = ledOnSprite;
    }

}
