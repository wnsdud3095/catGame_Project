using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slot : MonoBehaviour
{
    public Item item;
    public Image itemIcon;


    // Start is called before the first frame update

    public void UpdataSlot()
    {
        itemIcon.sprite = item.itemImage;
        itemIcon.gameObject.SetActive(true);
    }

    public void RemoveSlot()
    {
        item=null;
        itemIcon.gameObject.SetActive(false);

    }

    public void OnClick()
    {
        GameObject.Find("door").GetComponent<DecorateController>().WearItem = item;
    }



}
