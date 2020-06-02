using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryDetect : MonoBehaviour
{
    public bool isOpenBattery;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        GameObject inventorysystem = GameObject.FindWithTag("Inventory");
        Debug.Log(inventorysystem.GetComponent<InventorySystem>().currentitem());
        if (inventorysystem.GetComponent<InventorySystem>().currentitem() == "batteryItem")
        {
            Debug.Log("KEY DETECTED");
            inventorysystem.GetComponent<InventorySystem>().remove();
            isOpenBattery = true;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "batteryKey")
        {
            isOpenBattery = true;
        }
    }
}
