﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFire : MonoBehaviour
{
    public float holdTime = 1f;
    public WaitForSeconds waitForSeconds;
    public bool canRun = true;
    public GameAction gameActionObj;

    private void Awake()
    {
        waitForSeconds = new WaitForSeconds(holdTime);
    }

    private IEnumerator OnMouseDown()
    {
        canRun = true;
        while (canRun)
        {
            gameActionObj.Raise();
            yield return waitForSeconds;
        }
    }

    private void OnMouseUp()
    {
        canRun = false;
    }
}
