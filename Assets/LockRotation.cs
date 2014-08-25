using UnityEngine;
using System.Collections;

public class LockRotation : MonoBehaviour {

	private Quaternion lockValue;
	private Vector3 lockPosition;

	// Use this for initialization
	void Start () {
		lockValue = transform.rotation;
		lockPosition = transform.localPosition;
	}
	
	void LateUpdate () {
		transform.rotation = lockValue;
		transform.localPosition = lockPosition;
	}
}
