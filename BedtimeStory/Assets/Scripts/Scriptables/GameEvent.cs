using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Curious Learning/Game Event")]
public class GameEvent : ScriptableObject {

    List<GameEventListener> gameEventListeners = new List<GameEventListener>();

    public void Raise()
    {
        for (int i = 0; i < gameEventListeners.Count; i++)
        {
            gameEventListeners[i].OnEventRaised();
        }
    }

    public void GameOver()
    {
        for (int i = 0; i < gameEventListeners.Count; i++)
        {
            gameEventListeners[i].OnEventGameOver();
        }
    }

    public void ButtonClick()
    {
        for (int i = 0; i < gameEventListeners.Count; i++)
        {
            gameEventListeners[i].OnEventButtonClick();
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
