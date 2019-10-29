using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
	private void Awake()
	{
		GetComponent<Collider>().isTrigger = true;
	}

	public UnityEvent enterEvent, exitEvent;
	

	private void OnTriggerEnter(Collider other)
	{
		enterEvent.Invoke();
	}

	private void OnTriggerExit(Collider other)
	{
		exitEvent.Invoke();
	}
}
