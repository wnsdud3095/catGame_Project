using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarmeraController : MonoBehaviour
{
    GameObject player; // ī�޶� ���� ������Ʈ�� �� ����

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("catPrefab"); // cat�̶�� �̸��� ������Ʈ�� ã�Ƽ� ��ȯ
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(this.player.transform.position.x, this.player.transform.position.y, transform.position.z);
        // x�� y�� ��ġ�� player�� ���� zī�޶��� z�� -10���� �Ǿ��־ �÷��̾�� �������� ������Ʈ���� ������ ����
    }

}
