using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventClick : MonoBehaviour
{

	public UnityEvent mouseClick;

	private void OnMouseDown()
	{
		mouseClick.Invoke();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
