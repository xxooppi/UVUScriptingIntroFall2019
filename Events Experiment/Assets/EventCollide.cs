using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventCollide : MonoBehaviour
{

	public UnityEvent Event;

	private void OnTriggerEnter(Collider other)
	{
		Event.Invoke();
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
