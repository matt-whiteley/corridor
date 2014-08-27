using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	float speed = 0.20f;
	float turnSpeed = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		float v = speed * Input.GetAxis("Vertical");
		float h = speed * Input.GetAxis("Horizontal");
		float turn = turnSpeed * Input.GetAxis("Mouse X");
		MovementManager(v, h);
		RotationManager(turn);
	}

	void MovementManager(float vertical, float horizontal){
		//Vector3 targetDirection = new Vector3(horizontal, 0f, vertical);
		//Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);
		Vector3 targetPosition = new Vector3(horizontal, 0f, vertical) + transform.position;
		rigidbody.MovePosition(targetPosition);
	}

	void RotationManager(float turn){

		Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, turn, 0));
		rigidbody.MoveRotation(rigidbody.rotation * deltaRotation);
	}
}
