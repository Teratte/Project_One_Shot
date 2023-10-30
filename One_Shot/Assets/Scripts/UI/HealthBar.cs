using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerController;
    [SerializeField]
    private Image[] hpUI;
    [SerializeField]
    private Sprite heartOn;
    [SerializeField]
    private Sprite heartOff;

    public void Update()
    {
        for (int i = 0; i < hpUI.Length; i++)
        {
            if (i < playerController.Current_HP)
            {
                hpUI[i].sprite = heartOn;
            }
            else
            {
                hpUI[i].sprite = heartOff;
            }
        }
    }
}
