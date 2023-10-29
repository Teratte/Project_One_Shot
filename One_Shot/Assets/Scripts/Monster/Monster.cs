using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float speed = 5.0f;  // ���� ������ �ӵ�
    private Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        float dx = player.transform.position.x - transform.position.x;
        float dy = player.transform.position.y - transform.position.y;
        // ���� ������Ʈ���� Rigidbody2D ������Ʈ�� ã�� rbody�� �Ҵ�
        rbody = GetComponent<Rigidbody2D>();
        // Rigidbody2D�� �ӵ� = ���� ���� * �̵� �ӷ�
        rbody.velocity = new Vector2(transform.position.x, transform.position.y);

        // 3�� �ڿ� �ڽ��� ���� ������Ʈ �ı�
        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
