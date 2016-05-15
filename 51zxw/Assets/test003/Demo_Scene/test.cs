using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	private Vector3 mTargetPos;
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (1)) {
			Debug.Log("111111111111111111111");
			Vector3 mScreenPos = Input.mousePosition;
			Ray mRay = Camera.main.ScreenPointToRay(mScreenPos);
			RaycastHit mHit;
			Debug.Log(Camera.main+"");
			if(Physics.Raycast(mRay,out mHit)){
				Debug.Log(mHit.collider.gameObject+""+mHit.collider.gameObject.tag);
				if(mHit.collider.gameObject.tag=="Terrain"){
					mTargetPos=mHit.point;
					transform.LookAt(mTargetPos);
					Debug.Log("pos:"+mTargetPos.x+"-"+mTargetPos.z);
					transform.gameObject.GetComponent<Animation>().Play("Run");
					//transform.Translate(Vector3.zero);
				    transform.Translate(Vector3.forward*10F);
				}
		    }
		}
		if (Input.GetMouseButtonUp (1)) {
			Debug.Log("00000000000000");
			transform.gameObject.GetComponent<Animation>().Play("Idle");
		}
	}
}