#pragma strict

function Start () {

}

function Update () {

}

function OnGUI(){
        var style = GUIStyle();
        style.normal.background = null;    //这是设置背景填充的
        style.normal.textColor=new Color(1,0,0);   //设置字体颜色的
        style.fontSize = 20;       //当然，这是字体颜色
        GUI.Label(new Rect(10,0,Screen.width,30),"Key: Q,E",style); 
        GUI.color = Color.red;
		if (GUI.Button (new Rect (80, 20, 60, 30), "return")) {
			Application.LoadLevel(0);
		}
}