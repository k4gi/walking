using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	//attach this to the empty Player object
	public GameObject subject; //what i'm orbiting around
	public GameObject camera; //the actual camera, for tilt control

	private Vector3 offset; //offset between this and subject

	void Start() {
		offset = transform.position - subject.transform.position;
	}

	void LateUpdate() {
		//Quaternion camera_turn_angle = Quaternion.AngleAxis( camera.transform.localRotation.z, Vector3.up );

		//offset = camera_turn_angle * offset;

		//transform.position = subject.transform.position + offset;

		//transform.RotateAround(subject.transform.position, Vector3.up, 20 * Time.deltaTime);
	}
}
