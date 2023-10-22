using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SweetPotatoController : MonoBehaviour
{
    // HP
    public int hp = 1;
    // �̵� �ӵ�
    public float speed = 6.0f;
    // �ִϸ��̼� �̸�
    public string idleAnime = "SweetPotatoIdle";  // ����
    // ���� �ִϸ��̼�
    string nowAnimation = "";
    string oldAnimation = "";

    float axisH;    // ������ �� (-1.0 ~ 0.0 ~1.0)
    float axisV;    // ������ �� (-1.0 ~ 0.0 ~1.0)
    Rigidbody2D rbody; // Rigidbody 2D

    public int arranged = 0;  // ��ġ �ĺ��� ���

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D ��������
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player ���� ������Ʈ ��������
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if(player != null)
        {
             // �÷��̾���� ���� ���ϱ�
             float dx = player.transform.position.x - transform.position.x;
             float dy = player.transform.position.y - transform.position.y;
             float rad = Mathf.Atan2(dy, dx);
             float angle = rad * Mathf.Rad2Deg;
             // �̵� ������ ���� �ִϸ��̼� ����
             if(angle > -45.0f && angle <= 45.0f)
             {
                 nowAnimation = idleAnime;
             }
             else if(angle > 45.0f && angle <= 135.0f)
             {
                 nowAnimation = idleAnime;
             }
             else if(angle >= -135.0f && angle <= -45.0f)
             {
                 nowAnimation = idleAnime;
             }
             else
             {
                 nowAnimation = idleAnime;
             }

             //�̵��� ���� �����
             axisH = Mathf.Cos(rad) * speed;
             axisV = Mathf.Sin(rad) * speed;
        }
    }

    private void FixedUpdate()
    {
       if(hp > 0)
       {
            // �̵�
            rbody.velocity = new Vector2(axisH, axisV);
            if(nowAnimation != oldAnimation)
            {
                // �ִϸ��̼� �����ϱ�
                oldAnimation = nowAnimation;
                Animator animator = GetComponent<Animator>();
                animator.Play(nowAnimation);
            }
       }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Parry")
        {
            // �����
            hp--;
            if(hp <= 0)
            {
                // �ı�!
                // =================
                // �ı� ����
                // =================
                // �浹 ���� ��Ȱ��
                GetComponent<CircleCollider2D>().enabled = false;
                // �̵� ����
                rbody.velocity = new Vector2(0, 0);
                // �ٷ� ����
                Destroy(gameObject);
            }
        }
    }
}
