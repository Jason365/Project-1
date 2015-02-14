using UnityEngine;
using System.Collections;

public class EnemySpawningScript: MonoBehaviour {
	
	public GameObject spawn1;
	public GameObject spawn2;
	public GameObject spawn3;
	public GameObject spawn4;
	public GameObject spawn5;

	Vector3 enemyOffset = new Vector3 (0, 0.5f, 0);
	
	public float spawnTimer = 0;
	
	void Update() {
		spawnTimer += 1;
		//-23 to 23
		
		if (spawnTimer == 0) {
			int position = Random.Range (-23, 23);
			Vector3 enemyOffset = new Vector3 (position, 0.5f, 0);

			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate (spawn1, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 200){
			int position = Random.Range (-23, 23);
			Vector3 enemyOffset = new Vector3 (position, 0.5f, 0);

			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(spawn2, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 400){
			int position = Random.Range (-23, 23);
			Vector3 enemyOffset = new Vector3 (position, 0.5f, 0);

			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(spawn3, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 600){
			int position = Random.Range (-23, 23);
			Vector3 enemyOffset = new Vector3 (position, 0.5f, 0);

			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(spawn4, transform.position + offset, transform.rotation);
		}
		if(spawnTimer == 800){
			int position = Random.Range (-23, 23);
			Vector3 enemyOffset = new Vector3 (position, 0.5f, 0);

			Vector3 offset = transform.rotation * enemyOffset;
			
			Instantiate(spawn5, transform.position + offset, transform.rotation);
		}
		if(spawnTimer >= 1000){
			spawnTimer = 0;
		}
	}
}
