﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel_Manager : MonoBehaviour {
    
    public GameObject Main_Panel;
    public GameObject Config_Panel;
    public GameObject PopUp_TroChoiMoi_Panel;
    public GameObject Input_NewGame_Panel;
    public GameObject Select_Panel;
    private void Awake()
    {
        LoadInfomation.LoadAllInfomation();
        if (GameInfomation.Playername == "" && GameInfomation.Playerage == 0)
        {
            GameObject btnTiepTuc = GameObject.Find("btn_TiepTuc");
            if(btnTiepTuc.activeSelf)
                btnTiepTuc.SetActive(false);
        }
        
    }
    public void btn_Cuahang()
    {
        LoadInfomation.LoadAllInfomation();
        Debug.Log(GameInfomation.Playername);
        Debug.Log(GameInfomation.Playerage);
    }

    public void btn_tieptuc()
    {
        Main_Panel.SetActive(false);
        Select_Panel.SetActive(true);
    }
    public void btn_TroChoiMoi()
    {
        LoadInfomation.LoadAllInfomation();
        if (GameInfomation.Playername == "" && GameInfomation.Playerage == 0)
        {
            Input_NewGame_Panel.SetActive(true);
        }
        else
        {
            open_PopUp_TroChoiMoi_Panel();
        }
    }
    public void btn_CauHinh()
    {
        open_Config_Panel();
        close_Main_Panel();
    }
    public void btn_Thoat()
    {
        Application.Quit();
    }

    public void close_Config_Panel()
    {
        Config_Panel.SetActive(false);
    }
    public void open_Config_Panel()
    {
        Config_Panel.SetActive(true);
    }

    public void close_Main_Panel()
    {
        Main_Panel.SetActive(false);
    }
    public void open_Main_Panel()
    {
        Main_Panel.SetActive(true);
    }

    public void close_PopUp_TroChoiMoi_Panel()
    {
        PopUp_TroChoiMoi_Panel.SetActive(false);
        open_Main_Panel();
    }
    public void open_PopUp_TroChoiMoi_Panel()
    {
        PopUp_TroChoiMoi_Panel.SetActive(true);
        close_Main_Panel();
    }
    public void OK_PopUp_TroChoiMoi_Panel()
    {
        PopUp_TroChoiMoi_Panel.SetActive(false);
        Input_NewGame_Panel.SetActive(true);
    }
    public void bt_Numbers()
    {
        GameInfomation.scenePlay = "bt_Numbers";
        loadScene(1);
    }
    public void bt_Alphabet()
    {
        GameInfomation.scenePlay = "bt_Alphabet";
        loadScene(1);
    }
    public void bt_Fruit()
    {
        GameInfomation.scenePlay = "bt_Fruit";
        loadScene(1);
    }
    public void loadScene(int sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
