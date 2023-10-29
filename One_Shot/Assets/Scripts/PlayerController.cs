using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    int max_hp = 3; // 최대 hp

    private int current_hp = 1;
    private float angle;
    Vector2 target, mouse;
    Rigidbody2D rbody;

    private void Start()
    {
        current_hp = max_hp;
        Debug.Log(current_hp);
        rbody = GetComponent<Rigidbody2D>();
        target = transform.position;
    }
    private void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Heart")
        {
            if (current_hp == max_hp)
            {
            }
            else if (current_hp < max_hp)
            {
                current_hp += 1;
                Debug.Log("체력 1회복 ");
            }
        }
        if (collision.gameObject.tag == "Enemy")
        {
            current_hp -= 1;
            Debug.Log("체력 1감소 ");
        }
    }
}
