using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public Transform playerTransform;
	public Vector3 offsetPosition = new Vector3(0, 6, -3);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = playerTransform.position + offsetPosition;
	}
}
