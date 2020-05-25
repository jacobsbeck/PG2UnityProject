using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchRight : MonoBehaviour
{
    public trackingRoom trackRoom;
    // Start is called before the first frame update
    public void GoToRight()
    {
        Debug.Log("Ree");
        if (trackRoom.curRoom != "RoomSideRight")
        {
            trackRoom.prevRoom = trackRoom.curRoom;
            trackRoom.curRoom = "RoomSideRight";
            trackRoom.roomChange = true;
        }
    }

}
