using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameReset : MonoBehaviour
{

	public UnityEvent gameReset;

	private void OnDestroy()
	{
		gameReset.Invoke();
	}
}
