using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [Header("Scoring")]
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;

    private void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();

    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "Congratulations\nYou got a score of " + scoreKeeper.CalculateScore();
    }
}
