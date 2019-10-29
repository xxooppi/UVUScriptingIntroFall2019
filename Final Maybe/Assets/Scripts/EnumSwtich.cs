using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnumSwtich : MonoBehaviour {
	
	public enum States
	{
		Start, 
		Playing,
		End
	}

	public States currentStates;
	public UnityEvent onStartEvent, onPlayingEvent, onEndEvent;
	
	void Update () 
	{
		switch (currentStates)
		{
			case States.Start:
				onStartEvent.Invoke();
				break;
			case States.Playing:
				onPlayingEvent.Invoke();
				break;
			case States.End:
				onEndEvent.Invoke();
				break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
}
