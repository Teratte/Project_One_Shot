using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
<<<<<<< Updated upstream
=======
using Unity.VisualScripting;
using UnityEditor.Build.Content;
>>>>>>> Stashed changes
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    float axisH;                // 가로축 값(-1.0 ~ 0.0 ~ 1.0)
    float axisV;                // 세로축 값(-1.0 ~ 0.0 ~ 1.0)
    public float angleZ = -90.0f; // 회전 각

    bool isMoving = false;        // 이동 중인지 여부
    
    Rigidbody2D rbody;
<<<<<<< Updated upstream
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody2D 가져오기
=======

    public int Current_HP => current_hp;

    private void Start()
    {
        current_hp = max_hp;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            isMoving = true;
=======
            current_hp -= 1;
            Debug.Log("체력 1감소 ");
            if(current_hp == 0)
            {
                SceneManager.LoadScene(2);
            }
>>>>>>> Stashed changes
        }
    }
}
