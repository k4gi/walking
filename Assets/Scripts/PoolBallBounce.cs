using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBallBounce : MonoBehaviour {

	public GameObject player;
	public int speed = 1;
	public bool debugging = true;

	public void PushTheBall() {
		Rigidbody rb = GetComponent<Rigidbody>();
		/*
		float x_movement = Random.Range(-100.0f, 100.0f);
		float z_movement = Random.Range(-100.0f, 100.0f);
		rb.AddForce( x_movement, 0.0f, z_movement );
		*/
		Vector3 ballPoint = this.transform.position;

		//Ray ray = Camera.main.ScreenPointToRay ( new Vector3(Screen.width/2, Screen.height/2, Camera.main.nearClipPlane) );
		//Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
		Ray ray = Camera.main.ViewportPointToRay( new Vector3( 0.5f, 0.5f, 0.0f ) );

		//Vector3 clickPoint = ray.GetPoint (10) ;
		//clickPoint.z = 0;

		Vector3 clickPoint = player.transform.position;

		Vector3 forceVector = ballPoint - clickPoint;
		
		forceVector.Normalize();

		if(debugging) {
			Debug.Log( "====================" );
			Debug.Log( "ballPoint: " + ballPoint.x.ToString() + ",   " + ballPoint.y.ToString() + ",   " + ballPoint.z.ToString() );
			Debug.Log( "clickPoint: " + clickPoint.x.ToString() + ",   " + clickPoint.y.ToString() + ",   " + clickPoint.z.ToString() );
			Debug.Log( "forceVector: " + forceVector.x.ToString() + ",   " + forceVector.y.ToString() + ",   " + forceVector.z.ToString() );
		}
		rb.AddForce(forceVector * speed, ForceMode.Impulse);
	}
}
