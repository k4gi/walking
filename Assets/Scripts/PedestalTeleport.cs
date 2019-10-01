using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestalTeleport : MonoBehaviour {
	public GameObject player;
	public float height;

	public void Teleport() {
		Vector3 target = new Vector3( this.transform.position.x, this.transform.position.y+height, this.transform.position.z );
		player.transform.position = target;
	}
}
