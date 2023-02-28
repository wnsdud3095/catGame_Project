using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.Versioning;

public class UGUIdirector : MonoBehaviour
{
    public TextMeshProUGUI windowText;
    public TextMeshProUGUI resourceText;
    int myMoney;
    int wood = 10;
    int paper = 10;
    int stone = 10;
    public GameObject window;
    public GameObject resourceCheck;
    public bool windowActive = false;
    public bool resourceActive = false;

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
        //money.text = "���� �ڿ� :" + this.myMoney;

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

        resourceText.text = "���� : " + wood + "\n�ڽ� ���� : " + paper + "\n������ : " + stone;
        
    }

    public void resoruceOnOff()
    {
        resourceActive = !resourceActive;
        resourceCheck.SetActive(resourceActive);
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
