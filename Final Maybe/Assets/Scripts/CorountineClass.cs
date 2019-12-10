using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorountineClass : MonoBehaviour
{

	public bool canRun = true;
	public IntDataObject index;
	public float seconds;
	public WaitForSeconds wfsObj;

	public void Run()
	{
		wfsObj = new WaitForSeconds(seconds);
		StartCoroutine(OnRun());
	}
	IEnumerator OnRun() 
	{
		while (canRun)
		{
			yield return new WaitForSeconds(3f);
			Debug.Log("Run");
		}
		
	}
	
}
