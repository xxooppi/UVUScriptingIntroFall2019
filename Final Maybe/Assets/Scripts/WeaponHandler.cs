using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
	public WeaponData weaponObj;

	public void SwitchWeapon(WeaponData data)
	{
		weaponObj = data;
	}
	
	void Update ()
	{
		weaponObj.OnPurple();
	}
}
