using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs_1_Control : MonoBehaviour {

	bool open = false;

	void Update () {
		if(Input.GetKeyDown("space")){
			if(open){
				transform.Translate(0, -4, 0);
			} else {
				transform.Translate(0, 4, 0);
			}
			open = !open;
		}
		
	}
}
