using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MiMa : MonoBehaviour
{
    public Button[] btn;
    private string _password;
    public Text _Text;
    public InputField _Field;
    // Start is called before the first frame update
    public void Start()
    {
        btn[0].onClick.AddListener(btn_0);
        btn[1].onClick.AddListener(btn_1);
        btn[2].onClick.AddListener(btn_2);
        btn[3].onClick.AddListener(btn_3);
        btn[4].onClick.AddListener(btn_4);
        btn[5].onClick.AddListener(btn_5);
        btn[6].onClick.AddListener(btn_6);
        btn[7].onClick.AddListener(btn_7);
        btn[8].onClick.AddListener(btn_8);
        btn[9].onClick.AddListener(btn_9);
        btn[10].onClick.AddListener(btn_clean);
        btn[11].onClick.AddListener(btn_sure);
    }

    // Update is called once per frame
    private  void Update()
    {
       _Field.text = _password;
    }

    private void btn_0()
    {
        _password += "0";
    }

    private void btn_1()
    {
        _password += "1";
    }

    private void btn_2()
    {
        _password += "2";
    }

    private void btn_3()
    {
        _password += "3";
    }

    private void btn_4()
    {
        _password += "4";
    }

    private void btn_5()
    {
        _password += "5";
    }

    private void btn_6()
    {
        _password += "6";
    }

    private void btn_7()
    {
        _password += "7";
    }

    private void btn_8()
    {
        _password += "8";
    }

    private void btn_9()
    {
        _password += "9";
    }

    private void btn_clean()
    {
        _password = "";
    }

    private void btn_sure()
    {
        if("1234"==_password)
        {
            _Text.text = "√‹¬Î’˝»∑";
            SceneManager.LoadScene(1);
        }
        else
        {
            _Text.text = "√‹¬Î¥ÌŒÛ";
            _password = "";
        }
    }
}
