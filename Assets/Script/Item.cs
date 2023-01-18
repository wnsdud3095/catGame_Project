using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//아이템 이라는 클래스 만듬
public enum ItemType  //아이템 타입은 정해진것 중에 사용하기 위해 열거형 으로 선언
{
    Hat,
    Body,
    Pants

}

[System.Serializable] // System클래스의 Serializable이라는 키워드 : 클래스나 구조체들을 인스펙터 창에 노출시켜줌
public class Item

{
    public ItemType itemType;
    public string itemName;
    public Sprite itemImage;

    


}

