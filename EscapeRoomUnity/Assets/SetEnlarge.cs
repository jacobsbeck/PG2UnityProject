using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEnlarge : MonoBehaviour
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
        inventorysystem.GetComponent<InventorySystem>().setEnlarge();
    }
}
