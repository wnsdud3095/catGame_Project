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
    public Slot[] slots; // ������ SlotŬ���� Ÿ������ ���� ������Ʈ�� ���� �迭�� ����
    public Transform slotHolder; // ���Ե��� ��Ƶδ� ���� ����

    public GameObject Hat;
    public GameObject Body;
    public GameObject Pants;


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

    private void OnMouseDown() // Ŭ���� ȣ��Ǵ� �Լ� ������Ʈ�� �ݶ��̴��� �־�� �۵���
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

    public void UnWear()
    {
        Hat.SetActive(false);
        Body.SetActive(false);
        Pants.SetActive(false);

    }

}
