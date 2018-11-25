using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour {

    public GameEvent Event;
    public UnityEvent Response;

    private void OnEnable()
    {
        Event.Register(this);
    }

    private void OnDisable()
    {
        Event.DeRegister(this);
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }

    public void OnEventGameOver()
    {
        Response.Invoke();
    }

    public void OnEventButtonClick()
    {
        Response.Invoke();
    }
}
