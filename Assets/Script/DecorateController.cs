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

    private void OnMouseDown() // Ŭ���� ȣ��Ǵ� �Լ� ������Ʈ�� �ݶ��̴��� �־�� �۵���
    {
        decoratePanel.SetActive(true);
    }

    public void panelClose()
    {
        decoratePanel.SetActive(false);

    }


}
