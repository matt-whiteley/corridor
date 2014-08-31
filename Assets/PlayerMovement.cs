using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	float speed = 0.20f;
	float finalSpeed;
	//float turnSpeed = 10.0f;
	RaycastHit hit;
	Vector3 direction;
	Quaternion lookRotation;
	public Camera worldCam;

	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetAxis("Vertical") != 0 && Input.GetAxis("Horizontal") != 0){
			finalSpeed = speed * 0.7071f;
		}else{
			finalSpeed = speed;
		}
	
		float v = finalSpeed * Input.GetAxis("Vertical");
		float h = finalSpeed * Input.GetAxis("Horizontal");

		Vector3 mousePos = Input.mousePosition;
		Ray ray = worldCam.ScreenPointToRay(mousePos);

		MovementManager(v, h);
		RotationManager(ray);
	}

	void MovementManager(float vertical, float horizontal){
		Vector3 targetPosition = new Vector3(horizontal, 0f, vertical) + transform.position;
		rigidbody.MovePosition(targetPosition);
	}

	void RotationManager(Ray mousePoint){
		if(Physics.Raycast(mousePoint, out hit)){
			Vector3 _2Dhit = new Vector3(hit.point.x, transform.position.y, hit.point.z);
			direction = (_2Dhit - rigidbody.transform.position).normalized;
			lookRotation = Quaternion.FromToRotation(transform.forward, direction);
			rigidbody.MoveRotation(rigidbody.rotation * lookRotation);
		}
	}
}
