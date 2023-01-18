using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DecorateController : MonoBehaviour
{
    public GameObject Cat;
    public GameObject decoratePanel;
    public GameObject Inventory;
    public Slot[] slots; // 만들어둔 Slot클래스 타입으로 슬롯 오브젝트를 넣을 배열을 만듬
    public Transform slotHolder; // 슬롯들을 모아두는 변수 선언

    // Start is called before the first frame update
    void Start()
    {

        slots= slotHolder.GetComponentsInChildren<Slot>();
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
        if (Inventory.activeInHierarchy == true)
        {
            Inventory.SetActive(false);
            Cat.GetComponent<RectTransform>().Translate(480, 0, 0);

        }
        else decoratePanel.SetActive(false);


    }


    public void decorateStart()
    {

        Cat.GetComponent<RectTransform>().Translate(-480, 0, 0);
        Inventory.SetActive(true);
        decorateIV.Instance.AddItem(ItemDataBase.Instance.itemDB[0]);

        RedrawSlotUI();
    }

    public void RedrawSlotUI()
    {
        for(int i =0; i<decorateIV.Instance.items.Count;i++)
        {
            slots[i].item = decorateIV.Instance.items[i];
            slots[i].UpdataSlot();
        }
    }

}
