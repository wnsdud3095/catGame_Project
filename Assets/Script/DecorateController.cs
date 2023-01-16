using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorateController : MonoBehaviour
{
    GameObject Cat;
    GameObject decoratePanel;

    // Start is called before the first frame update
    void Start()
    {
        this.Cat = GameObject.Find("decorateCat");
        this.decoratePanel = GameObject.Find("decoratePanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() // 클릭시 호출되는 함수 오브젝트에 콜라이더가 있어야 작동함
    {
        decoratePanel.SetActive(true);
    }

    public void panelClose()
    {
        decoratePanel.SetActive(false);

    }


}
