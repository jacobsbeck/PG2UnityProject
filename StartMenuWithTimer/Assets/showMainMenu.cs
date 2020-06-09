using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject creditText;
    bool creditStatus;
    void Start()
    {
        creditStatus = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        creditStatus = !creditStatus;
        creditText.SetActive(creditStatus);
        this.gameObject.SetActive(false);
    }
}
