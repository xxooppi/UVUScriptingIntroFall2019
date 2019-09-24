using UnityEngine;

[CreateAssetMenu]
public class FloatDataHealth : ScriptableObject
{

	public float health = 2f;
	private int healthMin = 0;
	public void UpdateValue(float amount)
	{
		health += amount;
	}
}
