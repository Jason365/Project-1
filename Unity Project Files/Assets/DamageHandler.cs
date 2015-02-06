using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {

	public int health = 1;

	public float invulnPeriod = 0;

	float invulnerable = 0;
	int correctLayer;

	void Start() {
		correctLayer = gameObject.layer;
	}

	void OnTriggerEnter2D() {
		Debug.Log ("Trigger!");
	
		health--;
		invulnerable = invulnPeriod;

		gameObject.layer = 10;
	}
	void Update(){

		invulnerable -= Time.deltaTime;
		if (invulnerable <= 0) {
			gameObject.layer = correctLayer;
		}
		if (health <= 0) {
			Die ();
		}
	}

	void Die(){
		Destroy(gameObject);
	}
}
