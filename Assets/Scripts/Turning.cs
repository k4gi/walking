using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning : MonoBehaviour
{
	private float angle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    angle = transform.eulerAngles.y; //angle = transform.rotation.z; //Quaternion.Angle( Quaternion.identity, transform.localRotation );
	    Debug.Log( "Rotation    : " + transform.eulerAngles.ToString("F5") );	
    }
}
