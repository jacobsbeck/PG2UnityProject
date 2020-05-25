using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locker : MonoBehaviour
{
    public Camera cam;
    public GameObject main;
    public GameObject newUI;
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
        cam.transform.position = new Vector3(-19.54f, 0, -10);
        main.SetActive(false);
        newUI.SetActive(true);
    }
}
