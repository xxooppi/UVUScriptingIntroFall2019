using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventExperiment : MonoBehaviour
{

	public UnityEvent invisibility;

	private void OnBecameInvisible()
	{
		invisibility.Invoke();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
