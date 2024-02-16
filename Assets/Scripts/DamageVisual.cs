using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DamageVisual : MonoBehaviour
{
    public Tilemap damageMap;
    public DamageTile[] damageTiles;

    public void UpdateDamageVisual(List<int> damageToDo)
    {
        // clear the damage map
        damageMap.ClearAllTiles();
        
        int y = 0;
        foreach (var dmg in damageToDo)
        {
            // set dmg - 1 tiles to the damageTiles[0]
            // set last tile to damageTiles[1]
            for (int i = 0; i < dmg - 1; i++)
            {
                damageMap.SetTile(new Vector3Int(-1, y, 0), damageTiles[0].tile);
                y++;
            }
            damageMap.SetTile(new Vector3Int(-1, y, 0), damageTiles[1].tile);
            y++;
        }
        
    }
}
