
using UnityEngine;

[CreateAssetMenu]
public class IntDataObject : ScriptableObject
{
    public int value = 1;

    public void UpdateValue(int number)
    {
        value += number;
        if (value < 0)
        {
            value = 0;
        }
    }
}
