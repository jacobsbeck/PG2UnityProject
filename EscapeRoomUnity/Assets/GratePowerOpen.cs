using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GratePowerOpen : MonoBehaviour
{
    public fuseMode fusemode;
    public Sprite bluemode;
    public Sprite normalMode;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (fusemode.isUV == true)
        {
            this.GetComponent<SpriteRenderer>().sprite = bluemode;

        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = normalMode;

        }
    }
}
