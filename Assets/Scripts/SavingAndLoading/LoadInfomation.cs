using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInfomation {

    public static void LoadAllInfomation()
    {
        GameInfomation.Playername = PlayerPrefs.GetString("CATCHEGGS_PLAYERNAME");
        GameInfomation.Playerage = PlayerPrefs.GetInt("CATCHEGGS_PLAYERAGE");
    }
}
