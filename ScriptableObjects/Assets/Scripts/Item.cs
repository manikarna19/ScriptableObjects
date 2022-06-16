using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu()]
public  class Item :ScriptableObject
{
    public ItemHub itemHub;
    public GameObject Stricker;
    public Texture ItsTexture;
    public float AimingHelp;
    public bool isSelected;
    public void OnSelectStricker()
    {
        itemHub.ReSelected();
        isSelected = true;
    }
    public void DeSelectSricker()
    {
        isSelected = false;
    }

}
