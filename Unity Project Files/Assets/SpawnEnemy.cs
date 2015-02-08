using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
	
	public GameObject enemy;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public Vector3 enemyOffset = new Vector3 (0, 0.5f, 0);

	public int spawnTimer = 0;

	void Update() {
		spawnTimer += 1;

		if (spawnTimer <= 1) {
			Vector3 offset = transform.rotation * enemyOffset;

			Instantiate (enemy, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 50){
				Vector3 offset = transform.rotation * enemyOffset;
				
				Instantiate(enemy2, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 100){
			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(enemy3, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 150){
			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(enemy4, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 200){
			spawnTimer = 0;
		}
	}
}
