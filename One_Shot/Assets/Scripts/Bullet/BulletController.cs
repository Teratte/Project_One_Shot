using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // ���� ������Ʈ�� ����
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ������ ���� ������Ʈ�� �ڽ����� �����ϱ�
        transform.SetParent(collision.transform);
        // �浹 ������ ��Ȱ��
        GetComponent<CircleCollider2D>().enabled = false;

        // ���� �ùķ��̼� ��Ȱ��
        GetComponent<Rigidbody2D>().simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 3);
    }
}
