using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SweetPotatoController : MonoBehaviour
{
    // HP
    public int hp = 1;
    // 이동 속도
    public float speed = 6.0f;
    // 애니메이션 이름
    public string idleAnime = "SweetPotatoIdle";  // 정지
    // 현재 애니메이션
    string nowAnimation = "";
    string oldAnimation = "";

    float axisH;    // 가로축 값 (-1.0 ~ 0.0 ~1.0)
    float axisV;    // 세로축 값 (-1.0 ~ 0.0 ~1.0)
    Rigidbody2D rbody; // Rigidbody 2D

    public int arranged = 0;  // 배치 식별에 사용

    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D 가져오기
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player 게임 오브젝트 가져오기
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if(player != null)
        {
             // 플레이어와의 각도 구하기
             float dx = player.transform.position.x - transform.position.x;
             float dy = player.transform.position.y - transform.position.y;
             float rad = Mathf.Atan2(dy, dx);
             float angle = rad * Mathf.Rad2Deg;
             // 이동 각도에 따른 애니메이션 설정
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

             //이동할 벡터 만들기
             axisH = Mathf.Cos(rad) * speed;
             axisV = Mathf.Sin(rad) * speed;
        }
    }

    private void FixedUpdate()
    {
       if(hp > 0)
       {
            // 이동
            rbody.velocity = new Vector2(axisH, axisV);
            if(nowAnimation != oldAnimation)
            {
                // 애니메이션 변경하기
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
            // 대미지
            hp--;
            if(hp <= 0)
            {
                // 파괴!
                // =================
                // 파괴 연출
                // =================
                // 충돌 판정 비활성
                GetComponent<CircleCollider2D>().enabled = false;
                // 이동 정지
                rbody.velocity = new Vector2(0, 0);
                // 바로 제거
                Destroy(gameObject);
            }
        }
    }
}
