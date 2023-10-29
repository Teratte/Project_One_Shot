using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerViewer : MonoBehaviour
{
    [SerializeField]
    private GameplayManager gameplayManager;
    [SerializeField]
    private TextMeshProUGUI timerText;

    private void Update()
    {
        timerText.text = $"Timer : {(int)gameplayManager.CurrentTime}";
    }
}
