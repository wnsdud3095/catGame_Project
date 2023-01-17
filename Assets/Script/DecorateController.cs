using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DecorateController : MonoBehaviour
{
    GameObject Cat;
    public GameObject decoratePanel;
    public GameObject Inventory;


    // Start is called before the first frame update
    void Start()
    {
        this.Cat = GameObject.Find("decorateCat");
        Inventory.SetActive(false);
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

    public void decorateStart()
    {
        Cat.GetComponent<RectTransform>().Translate(-300, 0, 0);
        Inventory.SetActive(true);
    }

}
