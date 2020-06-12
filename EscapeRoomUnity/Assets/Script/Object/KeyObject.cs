using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemObject", menuName = "Inventory/Item/Key")]

public class KeyObject : InventoryObject
{
    public void Awake()
    {
        type = ItemType.Key;
    }
}
