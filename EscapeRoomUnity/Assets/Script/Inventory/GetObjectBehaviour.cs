using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetObjectBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        
        // Destroy the gameObject after clicking on it
        GameObject inventorysystem = GameObject.FindWithTag("Inventory");
        inventorysystem.GetComponent<InventorySystem>().Additem(GetComponent<SpriteRenderer>().sprite);
        Destroy(gameObject);
        /*
        GameObject inventorysystem = GameObject.FindWithTag("Inventory");
        int availableSlot = inventorysystem.GetComponent<InventorySystem>().current_size;
        List<Image> inventory_list = inventorysystem.GetComponent<InventorySystem>().inventory_list;
        Vector3 buttonPosition = inventory_list[availableSlot].GetComponent<RectTransform>().position;
        transform.position = buttonPosition;
        */
    }
}
