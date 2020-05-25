using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSouth : MonoBehaviour
{
    public trackingRoom trackRoom;
    // Start is called before the first frame update
    public void GoToSouth()
    {
        Debug.Log("See");
        if (trackRoom.curRoom != "RoomSouth")
        {
            trackRoom.prevRoom = trackRoom.curRoom;
            trackRoom.curRoom = "RoomSouth";
            trackRoom.roomChange = true;
        }
    }

}
