using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventMouseEnter : MonoBehaviour
{

	public UnityEvent mouseEnter;

	private void OnMouseEnter()
	{
		mouseEnter.Invoke();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
