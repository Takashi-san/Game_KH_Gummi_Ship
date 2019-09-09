using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_orientation : MonoBehaviour {
	private GameObject cam = null;

	void Start() {
		// camera reference.
		cam = FindObjectOfType<Camera>().gameObject;
	}

	void Update() {
		//transform.LookAt(2 * transform.position - cam.transform.position);
		//transform.LookAt(2 * transform.position - new Vector3(transform.position.x, cam.transform.position.y, cam.transform.position.z));
		transform.LookAt(2 * transform.position - new Vector3(cam.transform.position.x, transform.position.y, cam.transform.position.z));
	}
}
