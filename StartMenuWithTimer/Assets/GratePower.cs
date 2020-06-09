using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GratePower : MonoBehaviour
{
    public fuseMode fusemode;
    public GameObject gratePuzzle;
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
            gratePuzzle.SetActive(true);
            this.GetComponent<SpriteRenderer>().sprite = bluemode;

        }
        else {
            gratePuzzle.SetActive(false);
            this.GetComponent<SpriteRenderer>().sprite = normalMode;
        }
    }
}
