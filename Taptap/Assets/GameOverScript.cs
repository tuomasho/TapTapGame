using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

    private int score;
    private int highscore;

    public Text scoreText;
    public Text highScoreText;

    private void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        highscore = PlayerPrefs.GetInt("HighScore", 0);

        if( score > highscore)
        {
            highscore = score;
        }

        scoreText.text = score.ToString();
        highScoreText.text = highscore.ToString();

        PlayerPrefs.SetInt("HighScore", highscore);
    }

    public void RestartButtonClicked()
    {
        SceneManager.LoadScene("main");
    }

    public void ExitButtonClicked()
    {
        Application.Quit();
    }
}
