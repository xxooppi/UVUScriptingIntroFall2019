using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class ApplyForce : MonoBehaviour
{

	private Rigidbody rb;
	
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void OnCollisionEnter(UnityEngine.Collision other)
	{
		rb.AddForce(0,10f,0);
	}
}
	
	
