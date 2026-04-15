using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject playScreen;
    public static bool isGameOver = false;

    public TextMeshProUGUI bestScoreUI;
    public TextMeshProUGUI yourScoreUI;

    private void Awake()
    {
        isGameOver = false;
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
            playScreen.SetActive(false);
            Time.timeScale = 0;
            bestScoreUI.text = "BEST SCORE: " + ScoreManager.bestScore;
            yourScoreUI.text = "YOUR SCORE: " + ScoreManager.nowScore;
        }
    }
}
