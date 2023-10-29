using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField]
    private float max = 3; //최대 체력
    private float currentHP; //현재 체력
    [SerializeField]
    private float secondPer = 1; //초당 올라갈 시간 초
    private float currentTime; //현재 시간 초
    private bool isGame = true; //현재 게임이 진행중인지

    public GameObject ingameUI;
    public GameObject gameoverUI;
    public GameObject pauseUI;
    public float CurrentHP => currentHP;
    public float CurrentTime => currentTime;
    public GameObject IngameUI => ingameUI;
    public GameObject GameoverUI => gameoverUI;
    public GameObject PauseUI => pauseUI;
    public bool IsGame => isGame;

    private void Awake()
    {
        ingameUI.SetActive(true);
        gameoverUI.SetActive(false);
        pauseUI.SetActive(false);
        currentHP = max;
    }
    private void Update()
    {
        Mathf.Clamp(0, currentHP, max);
        if (isGame == true)
        {
            ingameUI.SetActive(true);
            pauseUI.SetActive(false);
            currentTime += secondPer * Time.deltaTime;
            if (currentHP > 3)
            {
                currentHP = 3;
            }
            else if (currentHP == 0)
            {
                isGame = false;
                ingameUI.SetActive(false);
                gameoverUI.SetActive(true);
            }
            else if(Input.GetKeyDown(KeyCode.Escape) && isGame == true)
            {
                isGame = false;
                ingameUI.SetActive(false);
                pauseUI.SetActive(true);
            }
        }
    }

    public void Resume()
    {
        isGame = true;
    }


    //아래는 테스트 함수(실제 게임플레이 미사용)
    public void hpMinusTest()
    {
        currentHP -= 1;
    }
    public void hpPlusTest()
    {
        currentHP += 1;
    }
}
