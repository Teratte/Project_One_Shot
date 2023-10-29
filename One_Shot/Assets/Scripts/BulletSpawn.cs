using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    [SerializeField]
    public float BulletSpeed = 0.0f;

    private Transform BulletSpawnerPoint;
    public GameObject BulletPrefabs; // Bullet 생성
    const float FireDelay = 0.5f;
    private float FireTimer = 0.0f;
    bool fire = true;

    // Start is called before the first frame update
    void Start()
    {
        // 플레이어 오브젝트 자식오브젝트(BulletSpawner) 위치 찾아와서 설정
        BulletSpawnerPoint = this.transform.Find("BulletSpawner");
    }
    // Update is called once per frame
    void Update()
    {
        FireControl();
    }

    void FireControl()
    {
        if (fire)
        {
            if (FireTimer > FireDelay && Input.GetMouseButtonDown(0))
            {
                GameObject bullet = Instantiate(BulletPrefabs, transform.position, transform.rotation);
                Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();
                rbody.AddForce(transform.up * BulletSpeed, ForceMode2D.Impulse);
                FireTimer = 0;
            }
            else if (FireTimer > FireDelay && Input.GetMouseButton(0))
            {
                GameObject bullet = Instantiate(BulletPrefabs, transform.position, transform.rotation);
                Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();
                rbody.AddForce(transform.up * BulletSpeed, ForceMode2D.Impulse);
                FireTimer = 0;
            }
            else
            {
                Debug.Log("쿨타임");
            }
            FireTimer += Time.deltaTime;
        }
    }
}
