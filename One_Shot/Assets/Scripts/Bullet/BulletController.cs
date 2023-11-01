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
    // 게임 오브젝트에 접촉
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 접촉한 게임 오브젝트의 자식으로 설정하기
        transform.SetParent(collision.transform);
        // 충돌 판정을 비활성
        GetComponent<CircleCollider2D>().enabled = false;

        // 물리 시뮬레이션 비활성
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
