using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField]
    private float max = 3; //�ִ� ü��
    private float currentHP; //���� ü��
    [SerializeField]
    private float secondPer = 1; //�ʴ� �ö� �ð� ��
    private float currentTime; //���� �ð� ��
    private bool isGame = true; //���� ������ ����������

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


    //�Ʒ��� �׽�Ʈ �Լ�(���� �����÷��� �̻��)
    public void hpMinusTest()
    {
        currentHP -= 1;
    }
    public void hpPlusTest()
    {
        currentHP += 1;
    }
}
