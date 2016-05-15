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
		GUI.Label(new Rect(10,20,Screen.width,30),"select:"); 
		if (GUI.Button (new Rect (80, 20, 60, 30), "创建物体")) {
			Application.LoadLevel(1);
		}
		if (GUI.Button (new Rect (80, 60, 60, 30), "基础综合")) {
			Application.LoadLevel(2);
		}
		if (GUI.Button (new Rect (80, 100, 60, 30), "角色动作")) {
			Application.LoadLevel(3);
		}
		if (GUI.Button (new Rect (80, 140, 60, 30), "角色换装")) {
			Application.LoadLevel(4);
		}
	}
	public void echo(string msg){
		JDebug.Log (new string[]{msg});
		int number = int.Parse (msg);
		Application.LoadLevel(number);
	}
}
