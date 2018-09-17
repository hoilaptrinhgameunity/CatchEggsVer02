using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfomation : MonoBehaviour {
    public static int gameStatus;
    public static int catchStatus;
    public static string Playername { get; set; }
    public static int Playerage { get; set; }

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

    void Start()
    {
        gameStatus = (int)statusGame.batdau;
        catchStatus = (int)statusGame.batdau;
    }
}
