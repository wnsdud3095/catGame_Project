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
        //money.text = "보유 자원 :" + this.myMoney;

        switch (textNum)
        {
            case 0:
                {
                    windowText.text = "마을 업그레이드 시 나무 500개가 필요합니다.";
                    break;
                }
            case 1:
                {
                    windowText.text = "자원이 부족합니다.";
                    break ;
                }
        }

        resourceText.text = "나무 : " + wood + "\n박스 조각 : " + paper + "\n돌맹이 : " + stone;
        
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
