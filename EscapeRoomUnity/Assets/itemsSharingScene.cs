using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemsSharingScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject noteTaken;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (noteTaken == null)
        {
            this.gameObject.SetActive(false);
        }
        
    }
}
