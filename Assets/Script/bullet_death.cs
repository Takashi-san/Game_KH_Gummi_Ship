using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_death : MonoBehaviour {
	[SerializeField] GameObject death_fx = null;

	private void OnTriggerEnter(Collider other) {
		if (!other.gameObject.GetComponent<ship_movement>()) {
			if (death_fx) {
				Instantiate(death_fx, transform.position, Quaternion.identity);
			}
			Destroy(gameObject);
		}
	}
}
