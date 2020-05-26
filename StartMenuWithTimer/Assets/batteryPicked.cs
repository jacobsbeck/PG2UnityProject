using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryPicked : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPicked = false;
    public ClosetManager closetScene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (isPicked == false)
        {
            isPicked = true;
            closetScene.isEvent = true;
            GameObject inventorysystem = GameObject.FindWithTag("Inventory");
            inventorysystem.GetComponent<InventorySystem>().Additem(GetComponent<SpriteRenderer>().sprite);
        }
    }
}
