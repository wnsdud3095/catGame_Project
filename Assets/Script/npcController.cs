using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown() // Ŭ���� ȣ��Ǵ� �Լ� ������Ʈ�� �ݶ��̴��� �־�� �۵���
    {
        GameObject.Find("UGUIdirector").GetComponent<UGUIdirector>().windowOnOff();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
