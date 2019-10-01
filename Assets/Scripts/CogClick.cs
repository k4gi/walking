using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogClick : MonoBehaviour
{
	bool isOpen = false;
	public bool isLocked = false;
	public GameObject placedItem;
	public PedestalSlidingDoor pedestal;

	public void ClickCog() {
		if(!isLocked) {
			if(!isOpen) {
				placedItem.SetActive(true);
				pedestal.isLocked = false;
			}
		}
	}
}
