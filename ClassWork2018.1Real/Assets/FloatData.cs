
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{

    public float value = 1f;

    private void UpdateValue(float amount)
    {
        value += amount;
    }
}
