using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
    public static ItemDataBase Instance; // 싱글톤 패턴이다. 이 클래스 자체를 전역클래스로 만들어서 다른 스크립트에서 접근하기 쉽게 해준다
    private void Awake()
    {
        Instance= this;
    }

    public List<Item> itemDB= new List<Item>(); //Item타입의 리스트 선언 (Serializable화 되어있기 때문에 인스팩터창에서 자유롭게 아이템을 넣고 빼고 할 수 있음)

}
