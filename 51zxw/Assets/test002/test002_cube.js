#pragma strict

function Start () {

}
var speed = 5.0;
function Update () {
   transform.Rotate(0,-25*Time.deltaTime,0,Space.Self);
   
   if(Input.GetKey(KeyCode.Q)){
      transform.Rotate(-250*Time.deltaTime,0,0,Space.Self);
   }
   if(Input.GetKey(KeyCode.E)){
         var offx = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
      var offz = Input.GetAxis("Vertical")*Time.deltaTime*speed;
      transform.Translate(offx,0,offz);
   }
   


}
var bPlay = false;
function OnMouseDown(){
    if(bPlay){
      renderer.material.color = Color.gray;
      audio.Pause();
      bPlay = false;
    }else{
      renderer.material.color = Color.blue;
      audio.Play();
      bPlay = true;
    }
}