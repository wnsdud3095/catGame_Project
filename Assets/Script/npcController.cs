using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown() // 클릭시 호출되는 함수 오브젝트에 콜라이더가 있어야 작동함
    {
        GameObject.Find("UGUIdirector").GetComponent<UGUIdirector>().windowOnOff();
    }

    // Update is called once per frame
    void Update()
    {

    }

}
