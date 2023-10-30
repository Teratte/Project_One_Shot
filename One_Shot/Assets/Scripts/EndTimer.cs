using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndTimer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timerText;

    private void Update()
    {
        timerText.text = $"Timer : {(int)TimeMemory.time}";
    }
}
