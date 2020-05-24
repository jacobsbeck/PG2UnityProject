using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType {
    Key,
    Tool,
    Default
};

public abstract class InventoryObject : ScriptableObject
{
    public GameObject pref;
    public ItemType type;
    [TextArea(15, 20)]
    public string Description;
}
