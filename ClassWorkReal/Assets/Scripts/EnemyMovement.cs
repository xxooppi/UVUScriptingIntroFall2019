using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	private Rigidbody rb;
	public float speed = 3f;
	
	void FixedUpdate ()
	{
		Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		rb.AddForce(input*speed);
	}
}
