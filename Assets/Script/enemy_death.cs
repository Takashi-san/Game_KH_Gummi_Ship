using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_death : MonoBehaviour {
	[SerializeField] GameObject death_fx = null;

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.GetComponent<projectile>()) {
			if (death_fx) {
				Instantiate(death_fx, transform.position, Quaternion.identity);
			}
			Destroy(gameObject);
		}
	}
}
