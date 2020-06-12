using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackingRoom : MonoBehaviour
{
    public string curRoom;
    public string prevRoom;
    public bool roomChange = false;
    GameObject currentRoom = null;
    GameObject previousRoom = null;
    // Start is called before the first frame update
    void Awake()
    {
        curRoom = "RoomNorth";
        currentRoom = GameObject.FindGameObjectWithTag(curRoom);
        currentRoom.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        checkRoomUpdate(); 
    }

    private void checkRoomUpdate()
    {
        if (roomChange)
        {
            Debug.Log("aaj");
            currentRoom = GameObject.FindGameObjectWithTag(curRoom);
            previousRoom = GameObject.FindGameObjectWithTag(prevRoom);
            currentRoom.SetActive(true);
            previousRoom.SetActive(true);
            curRoom = prevRoom;
            roomChange = false;
        }
    }
}

