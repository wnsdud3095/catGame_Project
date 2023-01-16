using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.Versioning;

public class UGUIdirector : MonoBehaviour
{
    public TextMeshProUGUI money; // TMPŸ������ text������Ʈ�� ����
    public TextMeshProUGUI windowText;
    int myMoney;
    public GameObject window;
    public bool windowActive = false;
    sbyte textNum;


    

    // Start is called before the first frame update
    void Start()
    {
        this.myMoney = GameObject.Find("GameDirector").GetComponent<GameDirector>().myMoney;
        
        window.SetActive(windowActive);
    }

    // Update is called once per frame
    void Update()
    {
        money.text = "���� �ڿ� :" + this.myMoney;

        switch (textNum)
        {
            case 0:
                {
                    windowText.text = "���� ���׷��̵� �� ���� 500���� �ʿ��մϴ�.";
                    break;
                }
            case 1:
                {
                    windowText.text = "�ڿ��� �����մϴ�.";
                    break ;
                }
        }
        
    }

    

    public void windowOnOff()
    {
        textNum = 0;
        windowActive = !windowActive;
        window.SetActive(windowActive);
    }

    public void villageUp()
    {
        if(myMoney > 500)
        {
            myMoney -= 500;
            windowOnOff();
            GameObject.Find("TentDirector").GetComponent<TentDirector>().LV_UP();
        }
        else
        {
            textNum = 1;
        }
    }
}
