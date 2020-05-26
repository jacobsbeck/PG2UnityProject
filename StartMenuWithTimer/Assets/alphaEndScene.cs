using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alphaEndScene : MonoBehaviour
{
    public GameObject endScene;
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
        if (fusemode.isUV == true)
        {
            endScene.SetActive(true);
            soundManager.PlaySound("endAlpha");
        }
    }



}
