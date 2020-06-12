using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitDoorView : MonoBehaviour
{
    public Camera cam;
    public GameObject canvas;
    public GameObject newUI;
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
        cam.transform.position = new Vector3(39f, -55.7f, -10);
        canvas.SetActive(false);
        newUI.SetActive(true);
    }
}
