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

		pos.x += -Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;

		pos.y += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;

		transform.position = pos;

		//Restricting Camera Boundaries

		if (pos.x + shipBoundaryRadius > Camera.main.orthographicSize) {
			pos.x = Camera.main.orthographicSize - shipBoundaryRadius;
		}
		if (pos.x - shipBoundaryRadius < -Camera.main.orthographicSize) {
			pos.x = -Camera.main.orthographicSize + shipBoundaryRadius;
		}

		float screenRatio = (float)Screen.width / (float)Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;

		if (pos.y + shipBoundaryRadius > widthOrtho) {
			pos.y = widthOrtho - shipBoundaryRadius;
		}
		if (pos.y - shipBoundaryRadius < -widthOrtho) {
			pos.y = -widthOrtho + shipBoundaryRadius;
		}




		transform.position = pos;

	}
}
