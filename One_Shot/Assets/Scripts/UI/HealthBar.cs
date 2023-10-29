using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private GameplayManager gameplayManager;
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
            if (i < gameplayManager.CurrentHP)
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
