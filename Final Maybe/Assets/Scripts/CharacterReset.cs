using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterReset : MonoBehaviour
{
	public FloatData data;
	public float delay;
	public GameObject player;
	public WaitForSeconds wfsObj;
	private Transform startPosition;
	private GameObject startObj;
	void Start () 
	{
		startObj = new GameObject();
		startObj.transform.position = transform.position;
		wfsObj = new WaitForSeconds(delay);
		StartCoroutine(ResetPlayer());
	}

	IEnumerator ResetPlayer()
	{
		if (data.value <= 0)
		{
			Destroy(player);
			yield return wfsObj;
			data.value = 1f;
			Instantiate(player);
			transform.position = startObj.transform.position;

		}
	}
}
