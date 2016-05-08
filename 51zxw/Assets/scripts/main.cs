using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		JDebug.Log (new string[]{Application.dataPath+"","dddd"});
		//Application.LoadLevel (2);
	}
	
	// Update is called once per frame
	void Update () {

		
	}
	void OnGUI(){
		if (GUI.Button (new Rect (80, 20, 60, 30), "scene 1")) {
			Application.LoadLevel(1);
		}
		if (GUI.Button (new Rect (80, 60, 60, 30), "scene 2")) {
			Application.LoadLevel(2);
		}
	}
}
