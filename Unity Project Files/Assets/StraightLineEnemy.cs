using UnityEngine;
using System.Collections;

public class StraightLineEnemy : MonoBehaviour {

	
	void Start () {
		
	}
	
	void Update () {
		
		
		
		//Movement
		Vector3 pos = transform.position;
		
		pos.y += -0.2f;

		transform.position = pos;
	}
}
