using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTravel : MonoBehaviour
{
	public float speed = 3f;
	public float seconds = 4f;
	public Rigidbody rb;
	public WaitForSeconds wfsObj;
	private float damage = 1f;
	void Start ()
	{
		rb.velocity = transform.right * speed;
		wfsObj = new WaitForSeconds(seconds);
		StartCoroutine(DestroyWeapon());
	}

	IEnumerator DestroyWeapon()
	{
		yield return wfsObj;
		Destroy(gameObject);
	}

	private void OnTriggerEnter(Collider hitInfo)
	{
		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
		{
			enemy.UpdateHealth(damage);
		}
		Destroy(gameObject);
	}
}
