using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParryController : MonoBehaviour
{
    [SerializeField]
    private float ParryDuration = 0.0f; // 페링상태 지속시간
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.SetParent(collision.transform);
        GetComponent<CircleCollider2D>().enabled = false;

        GetComponent<Rigidbody2D>().simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, ParryDuration);
    }
}