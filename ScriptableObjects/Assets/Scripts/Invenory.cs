using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invenory : MonoBehaviour
{
    public GameEvent gameEvent;
    public GameEventListener gameEventListener;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameEventListener.OnEventRaised();
        }
        
    }
}
