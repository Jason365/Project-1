using UnityEngine;
using System.Collections;

public class TripleShot : MonoBehaviour {
	
	public GameObject bulletPrefab;
	public Vector3 bulletOffset = new Vector3 (0, 0.5f, 0);
	public float fireDelay = 1f;
	float cooldownTimer = 0;
	public Quaternion bulletRotation1;
	public Quaternion bulletRotation2;


	void Update () {
		cooldownTimer -= Time.deltaTime;
		
		if (cooldownTimer <= 0) {
			//Shoot Pew pew pew
			
			cooldownTimer = fireDelay;
			
			Vector3 offset = transform.rotation * bulletOffset;

			Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			Instantiate(bulletPrefab, transform.position + offset, transform.rotation * bulletRotation1);
			Instantiate(bulletPrefab, transform.position + offset, transform.rotation * bulletRotation2);

		}
	}
}
