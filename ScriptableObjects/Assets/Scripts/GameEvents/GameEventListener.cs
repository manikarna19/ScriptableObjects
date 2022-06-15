using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : ScriptableObject
{
    public GameEvent MyGameEvent;
    public UnityEvent Response;
    public void OnEventRaised()
    {
        Response.Invoke();
    }
 /*   private void OnEnable()
    {
        MyGameEvent.Register(this);
    }
    private void OnDisable()
    {
        MyGameEvent.UnRegister(this);
    }*/

}
