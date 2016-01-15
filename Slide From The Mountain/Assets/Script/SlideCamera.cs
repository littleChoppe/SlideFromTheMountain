using UnityEngine;
using System.Collections;

public class SlideCamera : MonoBehaviour {

	public GameObject target;
	
	void  LateUpdate () {
		transform.position = target.transform.position;
		
	}
}
