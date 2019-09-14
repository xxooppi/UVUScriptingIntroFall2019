using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseClick : MonoBehaviour
{

    public UnityEvent mouseClick;
    private void OnMouseDown()
    {
        mouseClick.Invoke();
    }
}
