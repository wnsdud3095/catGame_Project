using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������ �̶�� Ŭ���� ����
public enum ItemType  //������ Ÿ���� �������� �߿� ����ϱ� ���� ������ ���� ����
{
    Hat,
    Body,
    Pants

}

[System.Serializable] // SystemŬ������ Serializable�̶�� Ű���� : Ŭ������ ����ü���� �ν����� â�� ���������
public class Item

{
    public ItemType itemType;
    public string itemName;
    public Sprite itemImage;

    


}

