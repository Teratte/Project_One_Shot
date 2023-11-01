using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenManager : MonoBehaviour
{
    public GameObject titleButton1;
    public GameObject titleButton2;
    public GameObject controlButton;
    public GameObject controlText;
    public GameObject backButton;

    public void controlOn()
    {
        titleButton1.SetActive(false);
        titleButton2.SetActive(false);
        titleButton2.SetActive(false);
        controlText.SetActive(true);
        backButton.SetActive(true);
    }
    public void titleOn()
    {
        controlText.SetActive(false);
        backButton.SetActive(false);
        titleButton1.SetActive(true);
        titleButton2.SetActive(true);
        titleButton2.SetActive(true);
    }
}
