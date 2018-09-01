using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfomation {

	public static void SaveAllInfomation()
    {
        PlayerPrefs.SetString("PLAYERNAME", GameInfomation.Playername);
        PlayerPrefs.SetInt("PLAYERAGE", GameInfomation.Playerage);
    }
}
