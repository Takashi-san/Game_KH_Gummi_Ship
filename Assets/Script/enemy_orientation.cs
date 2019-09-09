using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_orientation : MonoBehaviour {
	GameObject focus = null;

	void Start() {
		focus = FindObjectOfType<ship_movement>().gameObject;
	}

	void Update() {
		transform.LookAt(focus.transform.position);
	}
}
