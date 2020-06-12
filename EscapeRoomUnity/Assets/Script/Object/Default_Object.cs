using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="ItemObject", menuName = "Inventory/Item/Default")]
public class Default_Object : InventoryObject
{
    public void Awake()
    {
        type = ItemType.Default;
    }
}
