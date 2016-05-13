#pragma strict

function Start (){}

function Update (){}
function OnTriggerStay (theCollider:Collider){
    Application.LoadLevel(1);  
}