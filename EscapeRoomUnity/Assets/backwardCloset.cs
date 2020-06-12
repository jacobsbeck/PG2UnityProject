using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backwardCloset : MonoBehaviour
{
    // Start is called before the first frame update
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
        if (closetScene.sceneCount == 0)
        {
            closetScene.sceneCount = 3;
            Debug.Log(closetScene.sceneCount);
        }
        else
        {
            closetScene.sceneCount--;
            //closetScene.isEvent = true;
        }
    }
}
