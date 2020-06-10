using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalKeyDetect : MonoBehaviour
{
    public GameObject endScene;
    public GameObject closedDoor;
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
        if (inventorysystem.GetComponent<InventorySystem>().currentitem() == "keyDoor")
        {
            SceneManager.LoadScene("Ending");
            Debug.Log("KEY DETECTED"); //if (inventorysystem.GetComponent<InventorySystem>().currentitem() == "Key-PNG-Clipart-Background")
            inventorysystem.GetComponent<InventorySystem>().remove();
        }
    }
}
