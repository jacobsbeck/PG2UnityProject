using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchNorth : MonoBehaviour
{
    public trackingRoom trackRoom;
    // Start is called before the first frame update
    public void GoToNorth()
    {
        Debug.Log("Nee");
        if (trackRoom.curRoom != "RoomNorth")
        {
            trackRoom.prevRoom = trackRoom.curRoom;
            trackRoom.curRoom = "RoomNorth";
            trackRoom.roomChange = true;
        }
    }

}
