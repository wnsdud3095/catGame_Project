using System;
using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement; // 씬을 관리할 수 있음

public class PlayerController : MonoBehaviour
{

    
    Rigidbody2D rigid2D;
    Animator anim;
    [SerializeField] // public으로 선언하지 않아도 인스펙터 창에서 보고 수정할수 있게 해줌
    float walkSpeed = 5.0f;
    sbyte dir = 0;  // 이동 방향을 나타내는 변수

    [SerializeField]
    float jumpPower = 5f;
    
    [SerializeField]
    Transform pos; // 땅을 감지할 원의 중심 위치
    [SerializeField]
    float checkRadius; // 당을 감지하는 원의 반지름
    [SerializeField]
    LayerMask islayer; // 매개변수로 전달하는 레이어값 변수
                       // LayerMask는 레이어를 나타내는 32비트의 int형 변수 , 레이어를 int형의 번호로 나타냄

    bool isGround;
    

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.anim = GetComponent<Animator>();
    }

    public Transform boxPos;
    public Vector2 boxSize;
    public void Attack()
    {
        Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(boxPos.position, boxSize, 0);
        foreach(Collider2D collider in collider2Ds)
        {
            
            if (collider.tag == "Enemy")
            {
                collider.GetComponent<Enemy>().GetDamage(1);
            }
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(boxPos.position, boxSize);
    }

    // Update is called once per frame
    void Update()
    {
      




        isGround = Physics2D.OverlapCircle(pos.position, checkRadius, islayer); // (Vector2, float radius, int layer) 위치에 반지름 크기의 원을 만들어 원 안에 존재하는 충동체 (Collider)를 가진 오브젝트를 검사
                                                                                // 레이어마스크를 매개변수로 전달시 해당 레이어 마스크가 있는지 검사후 참 거짓 반환

        // 플레이어 이동 제어
        dir = 0;  // 키를 누르고있지 않을때는 아무 이동도 없음
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir = -1;
            anim.SetBool("walk", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            dir = 1;
            anim.SetBool("walk", true);
        }

        if (dir == 0)
            anim.SetBool("walk", false);



        if (isGround)
            anim.SetTrigger("isGround");



        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            this.anim.SetTrigger("jump");
            rigid2D.velocity = Vector2.up * jumpPower;
        }
        if (dir != 0)
            transform.localScale = new Vector3(dir *2, 2, 1);



        if (this.rigid2D.velocity.y == 0) // 점프중이 아니면 재생속도를 이동속도에 맞추고
        {
            this.anim.speed = Math.Abs(this.rigid2D.velocity.x) / 2.0f; //애니메이션의 재생 속도를 바꾸려면 Animator컴포넌트에 speed변수를 조정해야함
        }
        else
            this.anim.speed = 1.0f; // 점프중이면 원래 애니메이션 속도로 재생


    }

    void FixedUpdate() // 업데이트는 프레임당 실행되는데 이거는 프레임과는 별도의 일정한 시간을 가지고 동작함 => 프레임간 시간차이를 고려할 필요 없음
    {
        // 좌우 이동
        rigid2D.velocity = new Vector2(dir * walkSpeed, rigid2D.velocity.y); // velocity는 질량과 관성등을 무시하고 입력된 속도로 움직임 -> 손가락을 때면 즉시 멈춰서 정밀한 컨트롤 가능하게 함

    }

    /*
    void OnTriggerEnter2D(Collider2D other) //콜리더와 충돌한 순간 호출되는 메서드 매개변수에는 충돌한 오브젝트가 들어감
    {
       // Debug.Log(other);
       // Debug.Log(other);
        SceneManager.LoadScene("Stage1");
    }
    */

    



}
