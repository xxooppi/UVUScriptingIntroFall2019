using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
[RequireComponent(typeof(Collider))]
public class EnemyPatrol : MonoBehaviour
{
	public GameObject obj;
	public float right;
	public float left;
	public float health;
	public float seconds;
	public WaitForSeconds wfsObj;
	private bool enemyMoving = true;
	private Collider trigger;
	private Vector3 position;
	
	private void Awake()
	{
		trigger = GetComponent<Collider>();
		trigger.isTrigger = true;
		wfsObj = new WaitForSeconds(seconds);
		enemyMoving = true;
		StartCoroutine(EnemyPatrolling());
	}

	IEnumerator EnemyPatrolling()
	{
		while (enemyMoving)
		{
			//transform.Translate(Time.deltaTime*right*Vector2.right);
			position.x = right * Time.deltaTime;
			yield return wfsObj;
			//transform.Translate(Time.deltaTime*right*Vector2.left);
			position.x = left * Time.deltaTime;
			yield return wfsObj;
		}
	}

	private void Update()
	{
		if (health <= 0)
		{
			enemyMoving = false;
			Destroy(obj);
		}
	}
}
