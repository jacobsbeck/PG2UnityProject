using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSafeMOde : MonoBehaviour
{
    public Camera cam;
    public NumPadMaster safePuzzle;
    public Sprite openSafe;
    int count = 0;
    public GameObject key;
    public AudioClip Ding;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (safePuzzle.isOpen == true && count != 1)
        {
            count++;
            StartCoroutine(waitToChange());
        }
    }

    IEnumerator waitToChange()
    {
        Debug.Log("ey");
        yield return new WaitForSecondsRealtime(2);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = openSafe;
        key.SetActive(true);
        cam.GetComponent<AudioSource>().PlayOneShot(Ding);
    }
}
