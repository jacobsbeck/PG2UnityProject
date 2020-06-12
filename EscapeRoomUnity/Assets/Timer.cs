using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    public Text time;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 600.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("Timer Active") == 1)
        {
            timeLeft -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(timeLeft / 60F);
            int seconds = Mathf.FloorToInt(timeLeft - minutes * 60);
            string timeInString = string.Format("{0:0}:{1:00}", minutes, seconds);
            time.text = "" + timeInString;
            if (timeLeft < 1)
            {
                SceneManager.LoadScene("GameOver");
            }
        }

    }
}
