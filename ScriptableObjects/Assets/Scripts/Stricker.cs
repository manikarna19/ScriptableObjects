using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stricker : MonoBehaviour
{
    public List<Item> AllStrikers = new List<Item>();
    public GameObject YourSelectedStricker;

  private void Start()
    {
        foreach (Item i in AllStrikers)
        {
            if (i.isSelected == true)
            {
                YourSelectedStricker = i.Stricker;
                Debug.Log(" you selected the stricker with Aiming Help as " + i.AimingHelp + " texture name as " + i.ItsTexture.name);
                break;
            }
        }
    }
}
