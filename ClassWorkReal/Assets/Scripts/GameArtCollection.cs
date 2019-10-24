using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<GameArtData> collectionList;

    public void AddData(GameArtData obj)
    {
        Debug.Log(collectionList[0]);
    }
}
