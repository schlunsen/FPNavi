using UnityEngine;
using System.Collections;
using UnityEditor;
using FPNavi;

[CustomEditor(typeof(IInterpolation))   ]
public class InterpolationEditor : Editor {

    public override void OnInspectorGUI()
    {
        Debug.Log("asd");
        GUILayout.Label("asd");
        //base.OnInspectorGUI();
        

    }
}
