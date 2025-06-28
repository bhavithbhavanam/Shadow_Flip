using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public static int totalCoins = 0;

    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 0;
        totalCoins = 0;
        UpdateScoreUI();
    }

    public static void RegisterCoin()
    {
        totalCoins++;
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public static bool AllCoinsCollected()
    {
        return score >= totalCoins;
    }
}
