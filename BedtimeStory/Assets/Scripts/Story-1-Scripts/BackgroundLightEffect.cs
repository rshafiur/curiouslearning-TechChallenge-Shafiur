using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundLightEffect : MonoBehaviour {

    Image image;

    public Color startColor;
    public Color endColor;

	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
        image.color = startColor;
	}
	
	public void ChangeBackgroundToWhite()
    {
        image.color = endColor;
    }
}
