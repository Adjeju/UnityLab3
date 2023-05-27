using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    public UnityEngine.UI.Button menuButton;
    public UnityEngine.UI.Button restartButton;
    public UnityEngine.UI.Button exitButton;
    public UnityEngine.UI.Button exitMenuButton;

    public GameObject pausePanel;
    public GameObject player;

    public TextMeshProUGUI goldText;
    public TextMeshProUGUI timeText;

    private bool isPause = false;
    private int[] time = new int[2];
    private int gold = 0;
    void Start()
    {
        menuButton.onClick.AddListener(OpenMenu);
        exitMenuButton.onClick.AddListener(OpenMenu);
        restartButton.onClick.AddListener(Restart);
        exitButton.onClick.AddListener(Exit);
        InvokeRepeating("OutputTime", 1f, 1f);
    }

    void OpenMenu()
    {
        isPause = !isPause;
        pausePanel.SetActive(isPause);
    }

    public void AddGold()
    {
        gold++;
        goldText.text = "Gold: " + gold;
    }

    void OutputTime()
    {
        if (!isPause)
        {

            if (time[0] != 59)
            {
                time[0]++;
            }
            else
            {
                time[0] = 0;
                time[1]++;
            }

            timeText.text = "Time: " + time[0] + ":" + time[1];
        }
    }

    void Exit()
    {
        Application.Quit();
    }

    void Restart()
    {
        time[0] = 0;
        time[1] = 0;
        gold = 0;
        timeText.text = "Time: " + time[0] + ":" + time[1];
        goldText.text = "Gold: " + gold;
        player.transform.position = new Vector3(-10.6f, 1, -11.6f);
    }
}
