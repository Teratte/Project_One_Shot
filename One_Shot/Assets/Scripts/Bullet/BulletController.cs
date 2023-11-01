using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    [SerializeField]
    private AudioClip deadSfx;

    private AudioSource deadSource;

    // Start is called before the first frame update
    void Start()
    {
        deadSource = GetComponent<AudioSource>();
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            deadSource.PlayOneShot(deadSfx);
            StartCoroutine(Dead());
        }
        else if (collision.gameObject.tag == "Heart")
        {
            deadSource.PlayOneShot(deadSfx);
            StartCoroutine(Dead());
        }
    }

    IEnumerator Dead()
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
