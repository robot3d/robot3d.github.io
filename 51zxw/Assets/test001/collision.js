#pragma strict

function Start () {

}

function Update () {

}
function OnCollisionEnter(obj:Collision){  
        Debug.Log("Collider:"+obj.collider.name+" gameObject:"+obj.gameObject.name);  
}