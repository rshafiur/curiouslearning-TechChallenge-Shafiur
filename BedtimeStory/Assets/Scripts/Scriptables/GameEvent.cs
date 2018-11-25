using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Event")]
public class GameEvent : ScriptableObject {

    List<GameEventListener> gameEventListeners = new List<GameEventListener>();

    public void Raise()
    {
        for (int i = 0; i < gameEventListeners.Count; i++)
        {
            gameEventListeners[i].OnEventRaised();
        }
    }

    public void LedTurnOn(int index)
    {
        for (int i = 0; i < gameEventListeners.Count; i++)
        {
            gameEventListeners[i].OnEventRaised();
        }
    }

    public void Register(GameEventListener listener)
    {
        if (!gameEventListeners.Contains(listener))
        {
            gameEventListeners.Add(listener);
        }
    }


    public void DeRegister(GameEventListener listener)
    {
        if (gameEventListeners.Contains(listener))
        {
            gameEventListeners.Remove(listener);
        }
    }
    
}
