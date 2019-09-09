using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_shoot : MonoBehaviour {
	[SerializeField] GameObject _ammo;
	[SerializeField] float _fireRate = 0;
	float _cd = 0;

	void Update() {
		_cd += Time.deltaTime;
		if (Input.GetButton("Jump") && _cd > _fireRate) {
			_cd = 0;
			Instantiate(_ammo, transform.position, transform.rotation);
		}
	}
}
