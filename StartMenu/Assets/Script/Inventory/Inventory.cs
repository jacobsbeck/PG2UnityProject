using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory/Inventory")]

public class Inventory : ScriptableObject
{
    public List<InventoryObject> Container = new List<InventoryObject>();
    public void AddItem(InventoryObject createitem)
    {
        bool hasitem = false;
        foreach(InventoryObject objectincontainer in Container)
        {
            if(objectincontainer == createitem)
            {
                hasitem = true;
                break;
            }
        }
        if (!hasitem)
        {
            Container.Add(createitem);
        }
    }
}

[System.Serializable]
public class InventorySlot
{
    public InventoryObject item;
    public InventorySlot(InventoryObject createitem)
    {
        item = createitem;
    }
}