using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableAction : MonoBehaviour {

    public GameEvent SwitchTurnEvent;

    public void Switch()
    {
        SwitchTurnEvent.Raise();
    }

    public void DisableObjectWithDelay()
    {
        Invoke("DisableObject", 0.5f);
    }

    private void DisableObject()
    {
        Destroy(this.gameObject);
    }
}
