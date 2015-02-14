using UnityEngine;
using System.Collections;

public class EnemyShooting : MonoBehaviour {

	public GameObject bulletPrefab;
	public Vector3 bulletOffset = new Vector3 (0, 0.5f, 0);
	public float fireDelay = 1f;
	float cooldownTimer = 0;
	
	void Update () {
		cooldownTimer -= Time.deltaTime;
		
		if (cooldownTimer <= 0) {
			//Shoot Pew pew pew

			cooldownTimer = fireDelay;
			
			Vector3 offset = transform.rotation * bulletOffset;
			
			Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			
		}
	}
}
