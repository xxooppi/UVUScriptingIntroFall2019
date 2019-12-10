using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{
	public Transform firePoint;
	public GameObject weaponPrefab;
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Fire();
		}	
	}

	void Fire()
	{
		Instantiate(weaponPrefab, firePoint.position, firePoint.rotation);
	}
}
