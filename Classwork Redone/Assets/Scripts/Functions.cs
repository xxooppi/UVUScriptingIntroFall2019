using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{

	public string playerName;
	private int myNumber;
	public float speed = 5f;
	public GameObject player;
	public Color playerColor = Color.cyan;

	// Use this for initialization
	void Start ()
	{
		Instantiate(original:ConfigureGameObject());
	}

	private GameObject ConfigureGameObject()
	{
		var newPlayer = Instantiate(player);
		newPlayer.layer = 0;
		newPlayer.active = true;
		newPlayer.tag = "player";
		newPlayer.transform.position = Vector3.zero;
		newPlayer.name = playerName;
		newPlayer.GetComponent<Renderer>().material.color = playerColor;

		return newPlayer;
	}

	private string WelcomePlayer()
	{
		return playerName + "Welcome to the game!";
	}

	private int AddNumbers(int a, int b)
	{
		print(a + b);
		return a + b;
	}

	private float IncreaseSpeed(float multiplayer)
	{
		return speed * multiplayer;
	}
}
