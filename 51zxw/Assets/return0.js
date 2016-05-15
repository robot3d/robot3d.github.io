#pragma strict

function Start () {

}

function Update () {

}
function OnGUI(){
		if (GUI.Button (new Rect (80, 20, 60, 30), "return")) {
			Application.LoadLevel(0);
		}
}