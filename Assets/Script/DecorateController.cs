using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DecorateController : MonoBehaviour
{
    public GameObject Cat;
    public GameObject decoratePanel;
    public GameObject Inventory;
    public Slot[] slots; // ������ SlotŬ���� Ÿ������ ���� ������Ʈ�� ���� �迭�� ����
    public Transform slotHolder; // ���Ե��� ��Ƶδ� ���� ����

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
