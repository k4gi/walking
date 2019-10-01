using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestalSlidingDoor : MonoBehaviour {
	public GameObject player;
	public Animator autodoor;
	public float height;
	Vector3 target;
	bool watch = false;
	public bool isLocked = false;

	public void Teleport() {
		target = new Vector3( this.transform.position.x, this.transform.position.y+height, this.transform.position.z );
		player.transform.position = target;
		if(!isLocked) {
			autodoor.SetBool("isOpen", true);
			watch = true;
		}
	}

	void Update() {
		if(watch) {
			if(player.transform.position != target) {
				autodoor.SetBool("isOpen", false);
				watch = false;
			}
		}
	}
}
