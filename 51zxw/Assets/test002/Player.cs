using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		transform.gameObject.GetComponent<Animation>().Play("walk");
	}
	private Vector3 mTargetPos;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Vector3 mScreenPos = Input.mousePosition;
			JDebug.Log(new string[]{mScreenPos.x+"",mScreenPos.z+""});
			Ray mRay = Camera.main.ScreenPointToRay(mScreenPos);
			RaycastHit mHit;
			if(Physics.Raycast(mRay,out mHit)){
				if(mHit.collider.gameObject.tag=="Terrain"){
					mTargetPos=mHit.point;
					transform.LookAt(mTargetPos);
					transform.gameObject.GetComponent<Animation>().Play("run");
					//transform.Translate(Vector3.zero);
					transform.Translate(Vector3.forward*0.1F);
				}
			}
		}
		if (Input.GetMouseButtonUp (1)) {
			//transform.gameObject.GetComponent<Animation>().Play("Idle");
		}
	}
}
