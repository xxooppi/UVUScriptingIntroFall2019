﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvents : MonoBehaviour
{

	private Camera cam;

	private void Start()
	{
		cam = Camera.main;
	}

	private void OnMouseDown()
	{
		Debug.Log(cam);
	}
}
