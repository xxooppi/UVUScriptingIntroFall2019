using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

	public int a = 4;
	public int b = 5;
	public int c = 10;
	public string password = "OU812";
	public bool lightsOn = true;
	
	
	// Use this for initialization
	void Start () {

		if (a+b == c)
		{
			print(true);
		}

		if (password == "OU812")
		{
			print(true);
		}

		if (lightsOn)
		{
			print(true);
		}
	}
	
	
}
