using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParryOnOFF : MonoBehaviour
{
    [SerializeField]
    float parryDelay = 0.5f;

    public GameObject parryPrefab;
    private float parryTimer = 0.0f;
    bool ParryStatus = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ParryControl();
    }

    void ParryControl()
    {
        if (  ((parryTimer == 0)||(parryTimer > parryDelay)) && Input.GetMouseButtonDown(1))
         {
            GameObject parry = Instantiate(parryPrefab, transform.position, transform.rotation);
            Rigidbody2D rbody = parry.GetComponent<Rigidbody2D>();
            parryTimer = 0.0f;
         }
         
         parryTimer += Time.deltaTime;

    }
}
