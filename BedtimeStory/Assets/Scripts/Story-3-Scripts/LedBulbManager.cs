using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedBulbManager : MonoBehaviour {

    public LedBulb[] ledBulbs;
    private int ledNumber;

    public GameEvent SwitchTurnEvent;

    // Use this for initialization
    void Start () {
        ledNumber = 0;
        
    }
	
	public void LedTurnOn()
    {
        if (ledBulbs.Length < ledNumber)
            return;
        else if (ledBulbs.Length == ledNumber)
        {
            SwitchTurnEvent.Raise();
        }
        else
        {
            ledBulbs[ledNumber].SpriteChange();
            ledNumber += 1;
        }
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
    }
}
