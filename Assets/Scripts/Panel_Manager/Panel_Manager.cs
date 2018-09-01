﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Manager : MonoBehaviour {
    
    public GameObject Main_Panel;
    public GameObject Config_Panel;
    public GameObject PopUp_TroChoiMoi_Panel;
    public GameObject Input_NewGame_Panel;

    public void btn_tieptuc()
    {
        scenesManager scm = new scenesManager();
        scm.scenesLoad(1);
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
        Debug.Log("Da reset data, ban hay choi lai tu dau");
        PopUp_TroChoiMoi_Panel.SetActive(false);
        Input_NewGame_Panel.SetActive(true);
    }
}