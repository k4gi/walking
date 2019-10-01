using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTeleport : MonoBehaviour {
	public GameObject player;
	public GameObject pedestal;
	public float height;

	public void Teleport() {
		Vector3 target = new Vector3( pedestal.transform.position.x, height, pedestal.transform.position.z );
		player.transform.position = target;
	}
}
