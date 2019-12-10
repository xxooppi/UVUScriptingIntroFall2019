using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public PlayerData playerDataObj;

    public void SwitchPlayer(PlayerData data)
    {
        playerDataObj = data;
    }

    /*public void OnRun()
    {
        
    }*/
}
