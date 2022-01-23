using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scorefield;
    public GameObject gameOverPanel;


    private void Start()
    {
        Time.timeScale = 1;
        gameOverPanel.SetActive(false);

    }

    private void Update()
    {
        CheckScoreAreValid();
    }
    int ConvertScoreToInt()
    {
        return int.Parse(scorefield.GetComponent<Text>().text);
    }
    void DisplayScore(int score)
    {
        scorefield.GetComponent<Text>().text = score.ToString();
    }
    public void DeductScore()
    {
        int scoreInt = ConvertScoreToInt();
        scoreInt--;
        DisplayScore(scoreInt);
    }

  
    public int GetScore()
    {
        return ConvertScoreToInt();       
    }

    void CheckScoreAreValid()
    {
        if (GetScore() == 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
