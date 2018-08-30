using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUILayout.BeginArea(new Rect(Screen.width / 2, Screen.height / 2 , 180, 250));
        GUILayout.Button("New Game", GUILayout.Width(180), GUILayout.Height(40));
        GUILayout.Button("Continue", GUILayout.Width(180), GUILayout.Height(40));
        GUILayout.Button("Setting", GUILayout.Width(180), GUILayout.Height(40));
        GUILayout.Button("Exit", GUILayout.Width(180), GUILayout.Height(40));
        GUILayout.EndArea();
    }
}
