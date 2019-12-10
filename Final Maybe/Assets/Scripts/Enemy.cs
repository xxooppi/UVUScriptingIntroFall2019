using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
[RequireComponent(typeof(Collider))]
public class Enemy : MonoBehaviour
{
	public GameObject obj;
	public float counterStart;
	public float counter = 5;
	public FloatData health;
	public float speed;
	public float seconds;
	public WaitForSeconds wfsObj;
	private Collider trigger;
	//private Vector3 position;
	////private bool enemyMoving = true;

	private void Awake()
	{
		trigger = GetComponent<Collider>();
		trigger.isTrigger = true;
		wfsObj = new WaitForSeconds(seconds);
		//enemyMoving = true;
		counter = counterStart;
		//StartCoroutine(EnemyPatrolling());
	}

	/*IEnumerator EnemyPatrolling()
	{
		while (counter > 0)
		{
			transform.Translate(Time.deltaTime*speed*Vector2.right);
			//position.x = rightSpeed * Time.deltaTime;
			counter--;
			yield return wfsObj;
			//Debug.Log(counter);
		}
		counter = counterStart;
		while (counter > 0)
		{
			transform.Translate(Time.deltaTime*speed*Vector2.left);
			//position.x = leftSpeed * Time.deltaTime;
			counter--;
			yield return wfsObj;
			//Debug.Log(counter);
		}
		counter = counterStart;
	}*/

	public void UpdateHealth(float damage)
	{
		health.value -= damage;
		if (health.value <= 0)
		{
			//StopCoroutine(EnemyPatrolling());
			Destroy(obj);
		}
	}

}
