using UnityEngine;
using System.Collections;
using UnityEditor;
using FPNavi;

[CustomEditor(typeof(Waypoint))]
public class WaypointEditor : Editor {

	// Use this for initialization
	void Start () {
	
	}


   public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();        
        
            
    }
	
	
}
