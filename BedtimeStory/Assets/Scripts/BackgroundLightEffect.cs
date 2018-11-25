using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundLightEffect : MonoBehaviour {

    Image image;

	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
        image.color = Color.black;
	}
	
	public void ChangeBackgroundToWhite()
    {
        image.color = Color.white;
    }
}
