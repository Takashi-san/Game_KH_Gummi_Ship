using UnityEngine;
using System.Collections;

public class particle_autodestroy : MonoBehaviour {
	private ParticleSystem ps;

	public void Start() {
		ps = gameObject.GetComponent<ParticleSystem>();
	}

	public void Update() {
		if (ps) {
			if (!ps.IsAlive()) {
				Destroy(gameObject);
			}
		}
	}
}
