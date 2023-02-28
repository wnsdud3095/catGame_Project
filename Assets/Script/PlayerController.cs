using System;
using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement; // ���� ������ �� ����

public class PlayerController : MonoBehaviour
{

    
    Rigidbody2D rigid2D;
    Animator anim;
    [SerializeField] // public���� �������� �ʾƵ� �ν����� â���� ���� �����Ҽ� �ְ� ����
    float walkSpeed = 5.0f;
    sbyte dir = 0;  // �̵� ������ ��Ÿ���� ����

    [SerializeField]
    float jumpPower = 5f;
    
    [SerializeField]
    Transform pos; // ���� ������ ���� �߽� ��ġ
    [SerializeField]
    float checkRadius; // ���� �����ϴ� ���� ������
    [SerializeField]
    LayerMask islayer; // �Ű������� �����ϴ� ���̾ ����
                       // LayerMask�� ���̾ ��Ÿ���� 32��Ʈ�� int�� ���� , ���̾ int���� ��ȣ�� ��Ÿ��

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
      




        isGround = Physics2D.OverlapCircle(pos.position, checkRadius, islayer); // (Vector2, float radius, int layer) ��ġ�� ������ ũ���� ���� ����� �� �ȿ� �����ϴ� �浿ü (Collider)�� ���� ������Ʈ�� �˻�
                                                                                // ���̾��ũ�� �Ű������� ���޽� �ش� ���̾� ����ũ�� �ִ��� �˻��� �� ���� ��ȯ

        // �÷��̾� �̵� ����
        dir = 0;  // Ű�� ���������� �������� �ƹ� �̵��� ����
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



        if (this.rigid2D.velocity.y == 0) // �������� �ƴϸ� ����ӵ��� �̵��ӵ��� ���߰�
        {
            this.anim.speed = Math.Abs(this.rigid2D.velocity.x) / 2.0f; //�ִϸ��̼��� ��� �ӵ��� �ٲٷ��� Animator������Ʈ�� speed������ �����ؾ���
        }
        else
            this.anim.speed = 1.0f; // �������̸� ���� �ִϸ��̼� �ӵ��� ���


    }

    void FixedUpdate() // ������Ʈ�� �����Ӵ� ����Ǵµ� �̰Ŵ� �����Ӱ��� ������ ������ �ð��� ������ ������ => �����Ӱ� �ð����̸� ����� �ʿ� ����
    {
        // �¿� �̵�
        rigid2D.velocity = new Vector2(dir * walkSpeed, rigid2D.velocity.y); // velocity�� ������ �������� �����ϰ� �Էµ� �ӵ��� ������ -> �հ����� ���� ��� ���缭 ������ ��Ʈ�� �����ϰ� ��

    }

    /*
    void OnTriggerEnter2D(Collider2D other) //�ݸ����� �浹�� ���� ȣ��Ǵ� �޼��� �Ű��������� �浹�� ������Ʈ�� ��
    {
       // Debug.Log(other);
       // Debug.Log(other);
        SceneManager.LoadScene("Stage1");
    }
    */

    



}
