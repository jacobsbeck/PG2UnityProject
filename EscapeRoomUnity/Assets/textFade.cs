using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textFade : MonoBehaviour
{
    public CanvasGroup target;
    public float speed = 1f;
    private float _t = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target.alpha != 1f)
        {
            _t += Time.deltaTime * speed;
            target.alpha = Mathf.PingPong(_t, 1f);
        }
    }
}
