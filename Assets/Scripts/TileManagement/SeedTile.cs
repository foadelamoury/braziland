using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/ToolAction/Seed Tile")]
public class SeedTile : ToolAction
{

    public override bool OnApplyToTileMap(Vector3Int gridPosition, TileMapReadController tileMapReadController, Item item)
    {
        if (tileMapReadController.cropsManager.Check(gridPosition) == false)
            return false;
        tileMapReadController.cropsManager.Seed(gridPosition, item.data.crop);

        return true;
    }
    public override void OnItemUsed(Item usedItem, Inventory inventory)
    {
        inventory.Remove(0);
    }
}
