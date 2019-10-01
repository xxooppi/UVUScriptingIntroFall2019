using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptablePlayer : ScriptableObject
{
	public GameObject player;
	public string playerName;
	public Color playerColor = Color.cyan;
	public 

	// Use this for initialization
	void Start ()
	{
		var addPlayer = Instantiate(player);

		addPlayer.layer = 0;
		addPlayer.active = true;
		addPlayer.transform.position = Vector3.zero;
		addPlayer.name = playerName;
		addPlayer.GetComponent<Renderer>().material.color = playerColor;
	}
	
}
