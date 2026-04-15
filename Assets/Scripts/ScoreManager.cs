using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI bestScoreUI;
    public static int bestScore;

    public TextMeshProUGUI nowScoreUI;
    public static int nowScore;

    private void Awake()
    {
        nowScore = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        bestScoreUI.text = "BEST SCORE: " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        nowScoreUI.text = "NOW SCORE: " + nowScore;
    }
}
