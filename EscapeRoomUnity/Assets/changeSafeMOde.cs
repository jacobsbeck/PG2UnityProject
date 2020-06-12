using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSafeMOde : MonoBehaviour
{
    public NumPadMaster safePuzzle;
    public Sprite openSafe;
    public GameObject key;
    public fuseMode fuseUV;
    public Sprite blueMode;
    public Sprite normalMode;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fuseUV.isUV == false && safePuzzle.isOpen == true && count == 0)
        {
            count = 1;
           StartCoroutine(waitToChange());
        }
        else if (fuseUV.isUV == true && safePuzzle.isOpen == true)
        {
            count = 2;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = blueMode;
        }
        else if (fuseUV.isUV == false && safePuzzle.isOpen == true && count == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = normalMode;
        }
    }

    IEnumerator waitToChange()
    {
        Debug.Log("ey");
        soundManager.PlaySound("SafeboxRight");
        yield return new WaitForSecondsRealtime(2);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = openSafe;
        key.SetActive(true);
    }
}
