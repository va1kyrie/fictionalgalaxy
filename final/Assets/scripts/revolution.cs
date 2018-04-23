using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolution : MonoBehaviour {

	public GameObject pivot;
	public int revdelt;
	public int rotdelt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//rotate
		transform.Rotate(Vector3.up * (rotdelt * Time.deltaTime));

		//get pivot
		if (!(this.gameObject.tag == "sun")) {
			transform.RotateAround (pivot.transform.position, Vector3.up, revdelt * Time.deltaTime);
		}

	}
}
