#pragma strict
/*
外力移动
*/
function Start () {
 
}

function Update () {
   if(Input.GetKey(KeyCode.E)){
     rigidbody.AddForce(Vector3(0,0,50));    
   }
}
function OnMouseDown(){
   rigidbody.AddForce(Vector3(0,400,0));
}