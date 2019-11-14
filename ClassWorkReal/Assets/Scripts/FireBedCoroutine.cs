using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FireBedCoroutine : MonoBehaviour
{
    private bool standingOn = false;
    public UnityEvent takeHealth;

    public void ChangeBool()
    {
        standingOn = true;
    }
    IEnumerator OnStep()
    {
        while (standingOn)
        {
            yield return new WaitForSeconds(1f);
            takeHealth.Invoke();
        }
    }

    IEnumerator EndCoroutine()
    {
        yield return new WaitForSeconds(3f);
        standingOn = false;
    }
}
