using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    private Transform BulletSpawnerPoint;
    public GameObject BulletPrefabs; // Bullet ����
    public float BulletSpeed = 5.0f;
    private float Shot_Delay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        // �÷��̾� ������Ʈ �ڽĿ�����Ʈ(BulletSpawner) ��ġ ã�ƿͼ� ����
        BulletSpawnerPoint = this.transform.Find("BulletSpawner");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(BulletPrefabs, transform.position, transform.rotation);
            Rigidbody2D rbody= bullet.GetComponent<Rigidbody2D>();
            rbody.AddForce(transform.up * BulletSpeed, ForceMode2D.Impulse);
        }
        else if (Input.GetMouseButton(0))
        {
            GameObject bullet = Instantiate(BulletPrefabs, transform.position, transform.rotation);
            Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();
            rbody.AddForce(transform.up * BulletSpeed, ForceMode2D.Impulse);
        }
    }
}
