#pragma strict
/**
用Instantiat复制Prefab 
*/
function Start () {

}
var source:GameObject;
function Update () {
   var go:GameObject = Instantiate(source,transform.position,transform.rotation);

}
function OnGUI(){
		if (GUI.Button (new Rect (80, 20, 60, 30), "return")) {
			Application.LoadLevel(0);
		}
}

