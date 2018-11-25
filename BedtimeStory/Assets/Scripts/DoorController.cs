using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class DoorController : MonoBehaviour
{
    public GameEvent gameEvent;
    public Sprite openImage;

    public void SpriteChange()
    {
        Invoke("ChangeWithDelay", 0.5f);
    }

    void ChangeWithDelay()
    {
        GetComponent<Image>().sprite = openImage;
        gameEvent.Raise();
    }

}
