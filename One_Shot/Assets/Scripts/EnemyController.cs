using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // HP
    public int hp = 1;
    // �̵� �ӵ�
    public float speed = 5.0f;
    // ���� �Ÿ�
    public float reactionDistance = 4.0f;
    // �ִϸ��̼� �̸�
    public string idleAnime = "EnemyIdle";  // ����
    // ���� �ִϸ��̼�
    string nowAnimation = "";
    string oldAnimation = "";

    float axisH;    // ������ �� (-1.0 ~ 0.0 ~1.0)
    float axisV;    // ������ �� (-1.0 ~ 0.0 ~1.0)
    Rigidbody2D rbody; // Rigidbody 2D

    bool isActive = false;    // Ȱ�� ����

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
        
    }
}
