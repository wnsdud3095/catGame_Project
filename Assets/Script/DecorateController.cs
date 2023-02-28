using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;


public class DecorateController : MonoBehaviour
{
    public GameObject Cat;
    public GameObject decoratePanel;
    public GameObject Inventory;
    public Item WearItem;
    public Slot[] slots; // 만들어둔 Slot클래스 타입으로 슬롯 오브젝트를 넣을 배열을 만듬
    public Transform slotHolder; // 슬롯들을 모아두는 변수 선언

    public GameObject Hat;
    public GameObject Body;
    public GameObject Pants;
    public GameObject inClosetButton;

    public Sprite[] catSP = new Sprite[4];
    int CurrentSp = 1;

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



    public void panelOpen() // 클릭시 호출되는 함수 오브젝트에 콜라이더가 있어야 작동함
    {
        decoratePanel.SetActive(true);
        inClosetButton.SetActive(false);
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
        decorateIV.Instance.AddItem(ItemDataBase.Instance.itemDB[1]);
        decorateIV.Instance.AddItem(ItemDataBase.Instance.itemDB[2]);
        decorateIV.Instance.AddItem(ItemDataBase.Instance.itemDB[3]);
        decorateIV.Instance.AddItem(ItemDataBase.Instance.itemDB[4]);
        decorateIV.Instance.AddItem(ItemDataBase.Instance.itemDB[5]);

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
    public void Wear()
    {



        if (WearItem.itemType == ItemType.Hat)
        {
            Hat.SetActive(true);
            Hat.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 300);
            Hat.GetComponent<Image>().sprite = WearItem.itemImage;
        }
        else if (WearItem.itemType == ItemType.Body)
        {
            Body.SetActive(true);
            Body.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 300);
            Body.GetComponent<Image>().sprite = WearItem.itemImage;

        }
        else if (WearItem.itemType == ItemType.Pants)
        {
            Pants.SetActive(true);
            Pants.GetComponent<RectTransform>().sizeDelta = new Vector2(300, 300);
            Pants.GetComponent<Image>().sprite = WearItem.itemImage;
        }


    }

    public void turnLeft()
    {
    

        CurrentSp--;
        if(CurrentSp < 0)
        {
            CurrentSp = 3;
        }
        Cat.GetComponent<Image>().sprite = catSP[CurrentSp] ;
    }

    public void turnRight()
    {
        CurrentSp++;
        if(CurrentSp >3) 
        {
            CurrentSp = 0;
        }
        Cat.GetComponent<Image>().sprite = catSP[CurrentSp];
    }

    public void UnWear()
    {
        
        
        
        if (WearItem.itemType == ItemType.Hat)
        {
            Hat.SetActive(false);
        }
        else if (WearItem.itemType == ItemType.Body)
        {
            Body.SetActive(false);

        }
        else if (WearItem.itemType == ItemType.Pants)
        {
            Pants.SetActive(false);
        }
    }



    void OnTriggerStay2D(Collider2D other)
    {

        if (decoratePanel.activeInHierarchy == false)
        {
            inClosetButton.SetActive(true);
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {

        inClosetButton.SetActive(false);
    }
}
