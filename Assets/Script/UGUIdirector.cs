using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UGUIdirector : MonoBehaviour
{
    public TextMeshProUGUI money; // TMPŸ������ text������Ʈ�� ����
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
        money.text = "���� �ڿ� :"+ myMoney;
        
    }

    public void windowOnOff()
    {
        windowActive = !windowActive;
        window.SetActive(windowActive);
    }
}
