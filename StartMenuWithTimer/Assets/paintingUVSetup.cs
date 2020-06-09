using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintingUVSetup : MonoBehaviour
{
    public fuseMode fuseUV;
    public Sprite blueMode;
    public Sprite normalMode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fuseUV.isUV == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = blueMode;
        }
        if (fuseUV.isUV == false)
        {
            this.GetComponent<SpriteRenderer>().sprite = normalMode;
        }
    }
}
