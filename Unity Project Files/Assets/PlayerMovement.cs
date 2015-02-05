using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	float maxSpeed = 20f;

	float shipBoundaryRadius = 1.8f;

	void Start () {
	
	}

	void Update () {



		//Movement
		Vector3 pos = transform.position;

		pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;

		pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;

		transform.position = pos;

		//Restricting Camera Boundaries

		if (pos.y + shipBoundaryRadius > Camera.main.orthographicSize) {
			pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
		}
		if (pos.y - shipBoundaryRadius < -Camera.main.orthographicSize) {
			pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
		}

		float screenRatio = (float)Screen.width / (float)Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;

		if (pos.x + shipBoundaryRadius > widthOrtho) {
			pos.x = widthOrtho - shipBoundaryRadius;
		}
		if (pos.x - shipBoundaryRadius < -widthOrtho) {
			pos.x = -widthOrtho + shipBoundaryRadius;
		}




		transform.position = pos;

	}
}
