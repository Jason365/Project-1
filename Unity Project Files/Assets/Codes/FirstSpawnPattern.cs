using UnityEngine;
using System.Collections;

public class FirstSpawnPattern: MonoBehaviour {
	
	public GameObject enemy;
	public GameObject enemy2;
	
	public float spawnTimer = 0;
	
	void Update() {
		spawnTimer += 1;
		
		if (spawnTimer == 1) {
			Vector3 enemyOffset = new Vector3 (10, 0.5f, 0);

			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate (enemy, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 100){
			Vector3 enemyOffset = new Vector3 (16, 0.5f, 0);

			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(enemy2, transform.position + offset, transform.rotation);

		}
		if(spawnTimer == 100){
			Vector3 enemyOffset = new Vector3 (4, 0.5f, 0);
			
			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(enemy2, transform.position + offset, transform.rotation);
			
		}
		if(spawnTimer == 200){
			Vector3 enemyOffset = new Vector3 (-10, 0.5f, 0);

			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(enemy, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 300){
			Vector3 enemyOffset = new Vector3 (-16, 0.5f, 0);

			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(enemy2, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 300){
			Vector3 enemyOffset = new Vector3 (-4, 0.5f, 0);
			
			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(enemy2, transform.position + offset, transform.rotation);
		}
		if(spawnTimer >= 301){
			Destroy(gameObject);
		}
	}
}
