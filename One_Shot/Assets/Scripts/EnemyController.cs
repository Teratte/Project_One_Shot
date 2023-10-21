using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // HP
    public int hp = 1;
    // 이동 속도
    public float speed = 5.0f;
    // 반응 거리
    public float reactionDistance = 4.0f;
    // 애니메이션 이름
    public string idleAnime = "EnemyIdle";  // 정지
    // 현재 애니메이션
    string nowAnimation = "";
    string oldAnimation = "";

    float axisH;    // 가로축 값 (-1.0 ~ 0.0 ~1.0)
    float axisV;    // 세로축 값 (-1.0 ~ 0.0 ~1.0)
    Rigidbody2D rbody; // Rigidbody 2D

    bool isActive = false;    // 활성 여부

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
        
    }
}
