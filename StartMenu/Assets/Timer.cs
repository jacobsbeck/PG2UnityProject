using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 10.0f;
        Debug.Log("" + timeLeft);
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        Debug.Log("" + timeLeft);
        if (timeLeft < 0)
        {
            Debug.Log("Game over");
        }
    }
}
