using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfomation : MonoBehaviour {
    public static int gameStatus = (int)statusGame.batdau;
    public static int catchStatus = 3;
    public static string Playername { get; set; }
    public static int Playerage { get; set; }
    public static string scenePlay = "";
    public static string Spawner;
    public enum statusGame
    {
        batdau,
        tamdung,
        tieptuc,
        ketthuc
    };
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
