using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float axisH;                // 가로축 값(-1.0 ~ 0.0 ~ 1.0)
    float axisV;                // 세로축 값(-1.0 ~ 0.0 ~ 1.0)
    public float angleZ = -90.0f; // 회전 각

    bool isMoving = false;        // 이동 중인지 여부
    
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D 가져오기
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPosition = new Vector2(axisH, axisV);
    }

    public void SetAxis(float h, float v)
    {
        axisH = h;
        axisV = v;
        if(axisH == 0 && axisV == 0)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }
    }
}
