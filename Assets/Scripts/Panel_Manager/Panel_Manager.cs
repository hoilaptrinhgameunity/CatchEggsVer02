using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Manager : MonoBehaviour {
    
    public GameObject Main_Panel;
    public GameObject Config_Panel;

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
}
