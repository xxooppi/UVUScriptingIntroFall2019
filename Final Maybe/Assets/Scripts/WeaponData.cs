using UnityEngine;

[CreateAssetMenu]
public class WeaponData : GameArtData
{
	public int weaponPower = 10;

	public void OnPurple()
	{
		weaponPower = 20;
	}
}
