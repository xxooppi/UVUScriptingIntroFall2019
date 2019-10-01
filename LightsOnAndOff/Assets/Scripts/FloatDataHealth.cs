using UnityEngine;

[CreateAssetMenu]
public class FloatDataHealth : ScriptableObject
{

	public float value = 2f;
	private int healthMin = 0;
	public void UpdateValue(float amount)
	{
		value += amount;
	}
}
