using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float speed = 5.0f;  // 몬스터 움직임 속도
    private Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        float dx = player.transform.position.x - transform.position.x;
        float dy = player.transform.position.y - transform.position.y;
        // 게임 오브젝트에서 Rigidbody2D 컴포넌트를 찾아 rbody에 할당
        rbody = GetComponent<Rigidbody2D>();
        // Rigidbody2D의 속도 = 앞쪽 방향 * 이동 속력
        rbody.velocity = new Vector2(transform.position.x, transform.position.y);

        // 3초 뒤에 자신의 게임 오브젝트 파괴
        Destroy(gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
