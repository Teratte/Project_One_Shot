using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float axisH;                // ������ ��(-1.0 ~ 0.0 ~ 1.0)
    float axisV;                // ������ ��(-1.0 ~ 0.0 ~ 1.0)
    public float angleZ = -90.0f; // ȸ�� ��

    bool isMoving = false;        // �̵� ������ ����
    
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D ��������
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
