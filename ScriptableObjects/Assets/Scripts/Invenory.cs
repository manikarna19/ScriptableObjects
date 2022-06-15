using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invenory : MonoBehaviour
{
    public GameEvent gameEvent;
    public GameEvent APressed;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(" space has ben pressed");
            gameEvent.RaiseEvent();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            APressed.RaiseEvent();
        }
        
    }
}
