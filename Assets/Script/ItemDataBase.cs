using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
    public static ItemDataBase Instance; // �̱��� �����̴�. �� Ŭ���� ��ü�� ����Ŭ������ ���� �ٸ� ��ũ��Ʈ���� �����ϱ� ���� ���ش�
    private void Awake()
    {
        Instance= this;
    }

    public List<Item> itemDB= new List<Item>(); //ItemŸ���� ����Ʈ ���� (Serializableȭ �Ǿ��ֱ� ������ �ν�����â���� �����Ӱ� �������� �ְ� ���� �� �� ����)

}
