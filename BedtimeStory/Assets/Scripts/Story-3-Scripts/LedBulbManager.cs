using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedBulbManager : MonoBehaviour {

    public LedBulb[] ledBulbs;
    private int ledNumber;

    public GameEvent gameEvent;

    // Use this for initialization
    void Start () {
        ledNumber = 0;
        
    }
	
	public void LedTurnOn()
    {
        if (ledBulbs.Length < ledNumber)
            return;

        else
        {
            ledBulbs[ledNumber].SpriteChange();
            ledNumber += 1;
            if (ledBulbs.Length == ledNumber)
                gameEvent.Raise();
        }
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
    }
}
