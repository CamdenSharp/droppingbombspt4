using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [Header("Default Score")]
    public int score = 0;
    [Header("Text Object for Displaying Score")]
    public Text scoreText;
    //New CODE
    [Header("Default Best Score")]
    public int bestScore = 0;
    [Header("Text Object for Displaying Best Score")]
    public Text bestScoreText;

    public void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddScore(int points)
    {
        score = score + points;
        scoreText.text = "Score: " + score.ToString();
        //New CODE
        if (score > bestScore)
        {
            bestScore = score;
        }
    }
}