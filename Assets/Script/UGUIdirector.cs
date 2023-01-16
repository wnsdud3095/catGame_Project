using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.Versioning;

public class UGUIdirector : MonoBehaviour
{
    public TextMeshProUGUI money; // TMP타입으로 text오브젝트를 선언
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
        money.text = "보유 자원 :" + this.myMoney;

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
