using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParryOnOFF : MonoBehaviour
{
    [SerializeField]
    float parryDelay = 0.5f;
    [SerializeField]
    private AudioClip parrySound;

    private AudioSource parrySfx;

    public GameObject parryPrefab;
    private float parryTimer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        parrySfx = GetComponent<AudioSource>();
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
            parrySfx.PlayOneShot(parrySound);

            GameObject parry = Instantiate(parryPrefab, transform.position, transform.rotation);
            Rigidbody2D rbody = parry.GetComponent<Rigidbody2D>();
            parryTimer = 0.0f;
         }
         
         parryTimer += Time.deltaTime;

    }
}
