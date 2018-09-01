using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfomation : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public static string Playername { get; set; }
    public static int Playerage { get; set; }
}
