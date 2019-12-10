using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class FlowerActivation : MonoBehaviour
{
    public UnityEvent activateEvent;

    private void OnMouseDown()
    {
        activateEvent.Invoke();
    }
}
