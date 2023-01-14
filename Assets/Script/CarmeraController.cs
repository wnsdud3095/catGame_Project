using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarmeraController : MonoBehaviour
{
    GameObject player; // 카메라가 따라갈 오브젝트가 들어갈 변수

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("catPrefab"); // cat이라는 이름의 오브젝트를 찾아서 반환
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(this.player.transform.position.x, this.player.transform.position.y, transform.position.z);
        // x와 y의 위치만 player를 따라감 z카메라의 z는 -10으로 되어있어서 플레이어와 같아지면 오브젝트들이 보이지 않음
    }

}
