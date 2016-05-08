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