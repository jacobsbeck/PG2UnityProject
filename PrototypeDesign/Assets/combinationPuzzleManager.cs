using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combinationPuzzleManager : MonoBehaviour
{
    // Start is called before the first frame update
    public padLockColumnUp col1;
    public padLockColumnUp col2;
    public padLockColumnUp col3;
    public padLockColumnUp col4;
    public padLockColumnUp col5;
    public GameObject puzzleCanvas;
    public int sentOnce = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (col1.clickerCounter == 11
            && col2.clickerCounter == 24
            && col3.clickerCounter == 3
            && col4.clickerCounter == 8
            && col5.clickerCounter == 0
            && sentOnce == 0)
        {
            sentOnce++;
            Debug.Log("unlocked");
            StartCoroutine(waitToChange());
        }

    }

    IEnumerator waitToChange()
    {
        Debug.Log("ey");
        yield return new WaitForSecondsRealtime(3);
        puzzleCanvas.SetActive(false);
    }
}
