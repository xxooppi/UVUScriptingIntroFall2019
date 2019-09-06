using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventRandom : MonoBehaviour
{

	public UnityEvent mouseExit;

	private void OnMouseExit()
	{
		mouseExit.Invoke();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
