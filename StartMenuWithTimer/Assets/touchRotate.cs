using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public int randomRotation = 0;

    private void Start()
    {
        transform.Rotate(0f, 0f, randomRotation);
    }
    private void OnMouseDown()
    {
        if (carPuzzleMaster.isWon == false)
        {
            transform.Rotate(0f, 0f, 90f);
            Debug.Log(transform.rotation.z);
        }
    }
    
}
