using UnityEngine;
using System.Collections;
/*
 * Application.ExternalCall( "SayHello", "The game says hello!" )
 * 
 * 
 * 在Unity3D中直接执行一段脚本代码如：

Application.ExternalEval("if(document.location.host!='unity3d.com'){document.location='http://unity3d.com';}")



<script type="text/javascript" language="javascript">
<!--function SaySomethingToUnity(
document.getElementById("UnityContent").SendMessage("MyObject", "MyFunction", "Hello from a web page!");
-->
</script>
 */

public class JDebug : MonoBehaviour {
	void Start(){
		JDebug.Log (new string[]{Application.dataPath+"","dddd"});
	}
	public static void Log(string[] list){
		//string msg = string.Join(",", (string[])list.ToArray(typeof( string)));
		string msg = string.Join (",",list);
		Debug.Log (msg);
		Application.ExternalCall ("console.log",msg);
	}
}
