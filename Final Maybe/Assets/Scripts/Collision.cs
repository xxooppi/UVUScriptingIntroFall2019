
using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class Collision : MonoBehaviour
{
	private void Awake()
	{
		GetComponent<Collider>().isTrigger = true;
	}

	public UnityEvent collision;
	private void OnTriggerEnter(Collider other)
	{
		collision.Invoke();
	}
}
