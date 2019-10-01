using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogKeyClick : MonoBehaviour
{
	public CogClick door;
	public GameObject sign;

	public void ClickKey() {
		if(sign != null) {
			sign.SetActive(true);
		}
		door.isLocked = false;
		gameObject.SetActive(false);
	}
}
