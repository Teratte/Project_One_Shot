using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    private float currentTime; //현재 시간 초
    private bool isGame; //현재 게임이 진행중인지
    private PlayerController playerController;

    public GameObject ingameUI;
    public GameObject pauseUI;
    public GameObject gameoverUI;
    public float CurrentTime => currentTime;
    public bool IsGame => isGame;

    private void Awake()
    {
        Time.timeScale = 1;
        isGame = true;
        ingameUI.SetActive(true);
        gameoverUI.SetActive(false);
        pauseUI.SetActive(false);
    }
    private void Update()
    {
        if(isGame == true)
        {
            currentTime += 1 * Time.deltaTime;
            TimeMemory.time = currentTime;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGame == true)
            {
                isGame = false;
                Time.timeScale = 0;
                ingameUI.SetActive(false);
                pauseUI.SetActive(true);
            }
            else if (isGame == false)
            {
                isGame = true;
                Time.timeScale = 1;
                ingameUI.SetActive(true);
                pauseUI.SetActive(false);
            }
        }
    }

    public void Resume()
    {
        isGame = true;
        Time.timeScale = 1;
        ingameUI.SetActive(true);
        pauseUI.SetActive(false);
    }

}
