using UnityEngine;

[CreateAssetMenu]
public class WeaponData : GameArtData
{
	public int weaponPower = 10;

	public void InstanceWeapon()
	{
		var newWeapon = Instantiate(prefab);
		var newSprite = newWeapon.GetComponentInChildren<SpriteRenderer>();
		newSprite.sprite = sprite;
		newSprite.color = color;
	}
	public void OnPurple()
	{
		weaponPower = 20;
	}
	
}
