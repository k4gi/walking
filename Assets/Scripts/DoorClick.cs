using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClick : MonoBehaviour
{
	bool isOpen = false;
	public Animator anim;
	public bool isLocked = false;

	public void ClickDoor() {
		if(!isLocked) {
			if(isOpen) {
				anim.SetTrigger("Close");
			} else {
				anim.SetTrigger("Open");
			}
			isOpen = !isOpen;
		}
	}
}
