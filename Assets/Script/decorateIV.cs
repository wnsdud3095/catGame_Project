using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decorateIV : MonoBehaviour
{
    public static decorateIV Instance; // �̱��� �����̴�. �� Ŭ���� ��ü�� ����Ŭ������ ���� �ٸ� ��ũ��Ʈ���� �����ϱ� ���� ���ش�
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
