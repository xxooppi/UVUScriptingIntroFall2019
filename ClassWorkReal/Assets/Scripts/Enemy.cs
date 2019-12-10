using System.Collections;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class Enemy : MonoBehaviour
{
	public GameObject obj;
	public float counterStart;
	public float counter = 5;
	public FloatData health;
	public float speed;
	public WaitForFixedUpdate wfsObj;
	private Collider trigger;
	private bool enemyMoving = true;
	
	private void Awake()
	{
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
				transform.Translate(Time.deltaTime*speed*Vector2.right);
				counter--;
				yield return wfsObj;
			}
			counter = counterStart;
			while (counter > 0)
			{
				transform.Translate(Time.deltaTime*speed*Vector2.left);
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
