using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_movement : MonoBehaviour {
	float _input_h;
	float _input_v;

	[SerializeField] float _speed = 5f;

	void Start() {
		// initial position.
		//transform.position = new Vector3(0, 0, 0);
	}

	void Update() {
		// Check input info in Unity: edit >> project settings... >> Input
		_input_h = Input.GetAxis("Horizontal");
		_input_v = Input.GetAxis("Vertical");

		transform.Translate(new Vector3(_input_h, _input_v, 0) * _speed * Time.deltaTime);
	}
}
