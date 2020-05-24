using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactBehaviour : MonoBehaviour
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
        GameObject inventorysystem = GameObject.FindWithTag("Inventory");
        Debug.Log(inventorysystem.GetComponent<InventorySystem>().currentitem());
        if (inventorysystem.GetComponent<InventorySystem>().currentitem() == "E_Walk")
        {
            inventorysystem.GetComponent<InventorySystem>().remove();
            Destroy(gameObject);
        }
        
    }
}
