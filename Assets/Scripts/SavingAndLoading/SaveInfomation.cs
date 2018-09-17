using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfomation {

	public static void SaveAllInfomation()
    {
        PlayerPrefs.SetString("CATCHEGGS_PLAYERNAME", GameInfomation.Playername);
        PlayerPrefs.SetInt("CATCHEGGS_PLAYERAGE", GameInfomation.Playerage);
    }
}
