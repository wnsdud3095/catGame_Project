using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UGUIdirector : MonoBehaviour
{
    public TextMeshProUGUI money; // TMP타입으로 text오브젝트를 선언
    int myMoney;
    public GameObject window;
    public bool windowActive = false;

    // Start is called before the first frame update
    void Start()
    {
        this.myMoney = GameObject.Find("GameDirector").GetComponent<GameDirector>().myMoney;
        window.SetActive(windowActive);
    }

    // Update is called once per frame
    void Update()
    {
        money.text = "보유 자원 :"+ myMoney;
        
    }

    public void windowOnOff()
    {
        windowActive = !windowActive;
        window.SetActive(windowActive);
    }
}
