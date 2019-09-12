using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DogClass : MonoBehaviour
{
    public UnityEvent puppers;
    private void OnMouseDown()
    {
        puppers.Invoke();
    }
}
