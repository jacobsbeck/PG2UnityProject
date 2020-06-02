using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinationPuzzleManagerDrawer : MonoBehaviour
{
    // Start is called before the first frame update
    public padLockColumnUp col1;
    public padLockColumnUp col2;
    public padLockColumnUp col3;
    public padLockColumnUp col4;
    public padLockColumnUp col5;
    public int sentOnce = 0;
    private bool puzzleSolved = false;
    public bool closetOpened = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (col1.clickerCounter == 1
            && col2.clickerCounter == 3
            && col3.clickerCounter == 2
            && col4.clickerCounter == 0
            && col5.clickerCounter == 3
            && sentOnce == 0)
        {
            sentOnce++;
            Debug.Log("unlocked");
            StartCoroutine(waitToChange());
            soundManager.PlaySound("unlockCypher");
        }

    }

    IEnumerator waitToChange()
    {
        Debug.Log("ey");
        yield return new WaitForSecondsRealtime(1);
        closetOpened = true;
    }
}
