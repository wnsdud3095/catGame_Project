using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decorateIV : MonoBehaviour
{
    public static decorateIV Instance; // 싱글톤 패턴이다. 이 클래스 자체를 전역클래스로 만들어서 다른 스크립트에서 접근하기 쉽게 해준다
    private void Awake()
    {
        Instance = this;
    }

    public List<Item> items = new List<Item>();

    public void AddItem(Item _item)
    {
        items.Add(_item);

    }
}
