using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
   public UnityAction<GameObject> instanceAction;
   public List<WeaponData> weapons;
   public ClothingData shirt;
   public ClothingData pants;
   public FloatData health;

   public void InstancePlayer()
   {
      var newPlayer = Instantiate(prefab);
      var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
      newSprite.sprite = sprite;
      newSprite.color = color;
      instanceAction(newPlayer);
   }
}
