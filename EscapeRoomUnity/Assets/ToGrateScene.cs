using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGrateScene : MonoBehaviour
{
    public Camera cam;
    public GameObject canvas;
    public GameObject newUI;
    public fuseMode fusemode;
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
        cam.transform.position = new Vector3(-0.02f, -49.7f, -10);
        canvas.SetActive(false);
        newUI.SetActive(true);
    }
}
