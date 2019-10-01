using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyClick : MonoBehaviour
{
	public DoorClick door;
	public GameObject sign;

	public void ClickKey() {
		if(sign != null) {
			sign.SetActive(true);
		}
		door.isLocked = false;
		gameObject.SetActive(false);
	}
}
