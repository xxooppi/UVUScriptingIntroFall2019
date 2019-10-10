using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
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
   }
}
