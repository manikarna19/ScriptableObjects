using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(PlayfabManager))]
public class SimplleButton : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Check"))
        {
            (target as PlayfabManager).RegisterToPlayfab();
        }
    }
}
