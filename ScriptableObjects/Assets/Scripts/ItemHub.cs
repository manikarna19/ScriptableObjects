using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu()]
public class ItemHub : ScriptableObject
{
    public List<Item> ALLItems = new List<Item>();
    
    public void ReSelected()
    {
        foreach(Item i in ALLItems)
        {
            i.isSelected = false;
        }
    }

    
}
