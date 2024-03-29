﻿using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<GameArtData> collectionList;

    public void AddData(GameArtData obj)
    {
        if (!collectionList.Contains(obj))
        {
           collectionList.Add(obj);
        }
    }
    
    public void RemoveLastItem(GameArtData obj)
    {
        collectionList.RemoveAt(collectionList.Count-1);
    }
    
}
