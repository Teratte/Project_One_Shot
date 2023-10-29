using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    [SerializeField]
    public float BulletSpeed = 0.0f;

    public GameObject BulletPrefabs; // Bullet »ý¼º
    const float FireDelay = 0.5f;
    private float FireTimer = 0.0f;
    bool fire = true;

    // Start is called before the first frame update
    void Start()
    {
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
                FireTimer = 0.0f;
            }
            else if (FireTimer > FireDelay && Input.GetMouseButton(0))
            {
                GameObject bullet = Instantiate(BulletPrefabs, transform.position, transform.rotation);
                Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();
                rbody.AddForce(transform.up * BulletSpeed, ForceMode2D.Impulse);
                FireTimer = 0.0f;
            }
            FireTimer += Time.deltaTime;
        }
    }
}
