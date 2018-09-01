using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_NewGame_Panel : MonoBehaviour {
    public InputField inputName;
    public InputField inputAge;
	// Use this for initialization
	void Start () {
        inputName.Select();
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            btn_DongY();
        }
       if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(inputName.isFocused){
                inputAge.Select();
            }
            else
            {
                inputName.Select();
            }
        }
    }
    public void btnNhapLai()
    {
        inputName.text = "";
        inputAge.text = "";
        inputName.Select();
    }

    public void btn_DongY()
    {
        check_btnDongY();
        //Debug.Log("Luu du lieu");
    }

    private void check_btnDongY()
    {
        if(inputName.text != "" && inputAge.text != "")
        {
            GameInfomation.Playername = inputName.text;
            GameInfomation.Playerage = int.Parse(inputAge.text);
            SaveInfomation.SaveAllInfomation();
            scenesManager scm = new scenesManager();
            scm.scenesLoad(1);
        }
        else
        {
            Debug.Log("Name hoac Age khong duoc de trong");
        }
    }
}
