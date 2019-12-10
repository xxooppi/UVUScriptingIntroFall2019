using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoRoutines : MonoBehaviour
{
    public UnityEvent repeatEvent, startEvent, endEvent;
    public float seconds = 2f;
    private int counter = 10;
    private WaitForSeconds wfsObj = new WaitForSeconds(1f);

    private void Awake()
    {
        wfsObj = new WaitForSeconds(seconds);
    }

    public void CallCoroutine()
    {
        StartCoroutine(RunCoroutine());
    }
    IEnumerator RunCoroutine()
    {
        startEvent.Invoke();
        while (counter > 0)
        {
            repeatEvent.Invoke();
            yield return wfsObj;
            counter--;
        }
        yield return wfsObj;
        Debug.Log("GO!");
        
        endEvent.Invoke();
    }
    
}
