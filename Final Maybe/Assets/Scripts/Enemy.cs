using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
[RequireComponent(typeof(Collider))]
//[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
	public GameObject obj;
	//public Rigidbody rb;
	public float counterStart;
	public float counter = 5;
	public FloatData health;
	public float speed;
	//public float seconds;
	public WaitForFixedUpdate wfsObj;
	private Collider trigger;
	//private Vector3 position;
	private bool enemyMoving = true;
	
	private void Awake()
	{
		/*rb = GetComponent<Rigidbody>();
		rb.useGravity = false;
		rb.freezeRotation = true;*/
		trigger = GetComponent<Collider>();
		trigger.isTrigger = true;
		wfsObj = new WaitForFixedUpdate();
		enemyMoving = true;
		counter = counterStart;
		StartCoroutine(EnemyPatrolling());
	}
	
	private void Start()
		{
			Debug.Log(counter);
		}
	
	IEnumerator EnemyPatrolling()
	{
		while (enemyMoving)
		{ 
			while (counter > 0)
			{
				//rb.velocity = Time.deltaTime * speed * transform.right;
				transform.Translate(Time.deltaTime*speed*Vector2.right);
				//position.x = rightSpeed * Time.deltaTime;
				counter--;
				//transform.rotation = Quaternion.Euler(0,180,0);
				yield return wfsObj;
			}
			counter = counterStart;
			while (counter > 0)
			{
				//rb.velocity = Time.deltaTime * speed * transform.right;
				transform.Translate(Time.deltaTime*speed*Vector2.left);
				//position.x = leftSpeed * Time.deltaTime;
				counter--;
				yield return wfsObj;
			}
			counter = counterStart;
		}
		
	}

	public void UpdateHealth(float damage)
	{
		health.value -= damage;
		if (health.value <= 0)
		{
			enemyMoving = false;
			Destroy(obj);
		}
	}

}
