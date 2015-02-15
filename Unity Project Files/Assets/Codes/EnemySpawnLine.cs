using UnityEngine;
using System.Collections;

public class EnemySpawnLine: MonoBehaviour {
	
	public GameObject enemy;
	public Vector3 enemyOffset = new Vector3 (0, 0.5f, 0);
	
	public float spawnTimer = 0;
	
	void Update() {
		spawnTimer += 1;
		
		if (spawnTimer == 10) {
			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate (enemy, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 30){
			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(enemy, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 50){
			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(enemy, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 70){
			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(enemy, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 90){
			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(enemy, transform.position + offset, transform.rotation);
		}
		if(spawnTimer >= 101){
			Destroy(gameObject);
		}
	}
}
