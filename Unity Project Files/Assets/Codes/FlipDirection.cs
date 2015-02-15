using UnityEngine;
using System.Collections;

public class FlipDirection : MonoBehaviour {

	// Move side to side nigga

	public float downSpeed = 20f;
	public float sideleftSpeed = 6f;
	public float siderightSpeed = -6f;
	public float smallEnemyBoundaryRadius = 1.8f;


	void Update () {

		float screenRatio = (float)Screen.width / (float)Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;

		Vector3 pos = transform.position;
		
		Vector3 velocity = new Vector3(0, downSpeed * Time.deltaTime, 0);

		pos += transform.rotation * velocity;
		
		transform.position = pos;

		if (pos.y + smallEnemyBoundaryRadius > 7) {
			Vector3 velocity2 = new Vector3(siderightSpeed * Time.deltaTime,0,0);
			pos += transform.rotation * velocity2;
			
			transform.position = pos;

		}
		if (pos.y - smallEnemyBoundaryRadius <= 7) {
		
			Vector3 velocity3 = new Vector3(sideleftSpeed * Time.deltaTime,0,0);
			pos += transform.rotation * velocity3;

			transform.position = pos;

		}


	}
}
