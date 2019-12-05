using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Follow : MonoBehaviour
{
	public Transform destination;
	public float speed = 3f;
	private Vector3 destinationDirection;
	private bool inRange = false;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			inRange = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		inRange = false;
	}


	void Update () 
	{
		if (inRange)
		{
			destinationDirection = destination.transform.position - transform.position;
			destinationDirection = destinationDirection.normalized;
			transform.Translate(destinationDirection*speed, Space.World);
		}
	}
}
