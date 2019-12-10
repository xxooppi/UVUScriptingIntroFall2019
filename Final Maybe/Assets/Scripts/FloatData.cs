using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float originalValue = 1f;
    public float value = 1f;

    public void UpdateValue(float amount)
    {
        if (value > originalValue)
        {
            value = originalValue;
        }
        else
        {
            value += amount;
        }
        
    }

    public void ResetValue()
    {
        value = originalValue;
    }
}
