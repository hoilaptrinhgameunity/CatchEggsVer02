using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Config_Panel_Manager : MonoBehaviour {
    public AudioMixer audioMixer;

    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volumeMaster", volume);
        Debug.Log(volume);
    }

    public void off_Music()
    {
        audioMixer.SetFloat("volumeMusic", -80);
    }
    public void on_Music()
    {
        audioMixer.SetFloat("volumeMusic", 0);
    }

    public void off_Effects()
    {
        audioMixer.SetFloat("volumeEffects", -80);
    }
    public void on_Effects()
    {
        audioMixer.SetFloat("volumeEffects", 0);
    }

    public void btn_Fanpage()
    {
        open_Fanpage();
    }
    public void btn_HuongDan()
    {
        open_HuongDan();
    }

    public void img_CloseSettingPanel()
    {
        gameObject.GetComponent<Panel_Manager>().close_Config_Panel();
        gameObject.GetComponent<Panel_Manager>().open_Main_Panel();
    }
    private void open_Fanpage()
    {
        Application.OpenURL("https://www.facebook.com/HoiLapTrinhGame/");
    }
	
    private void open_HuongDan()
    {
        Application.OpenURL("https://www.facebook.com/HoiLapTrinhGame/photos/a.1940778669529431/2138676153073014/?type=3");
    }
}
