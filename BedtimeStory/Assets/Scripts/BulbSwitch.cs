using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulbSwitch : MonoBehaviour {

    public GameEvent SwitchTurnEvent;

 // public BulbStateHolder bulbStateHolder;

    public void Switch()
    {
        SwitchTurnEvent.Raise();
        GetComponent<Button>().interactable = false;
    }

    /*
    public void Switch()
    {
        

        switch (bulbState)
        {
            case BulbState.On:
                SwitchTurnEvent.TurnOn();
                break;
            case BulbState.Off:
                break;
        }
    }
    */

}
