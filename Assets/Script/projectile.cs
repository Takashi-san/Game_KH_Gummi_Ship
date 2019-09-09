using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {
	[SerializeField] float _speed = 8f;
	[SerializeField] float _range = 1000f;

	float _deltaDist = 0;

	void Update() {
		_deltaDist += _speed * Time.deltaTime;
		transform.Translate(new Vector3(0, 0, 1) * _speed * Time.deltaTime);

		if (_deltaDist > _range) {
			Destroy(gameObject);
		}
	}
}
