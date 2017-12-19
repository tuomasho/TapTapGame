using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject circle;
    public int score = 0;
    public Text scoreText;

    private float spawnMin = 1f;
    private float spawnVar = 1f;
    private float spawnInc = -0.075f;

    private void Awake()
    {
            SpawnCircle();
            IncreaseDifficulty();
            UpdateScore();
    }

    void SpawnCircle()
    {
        Vector3 position = new Vector3(Random.Range(-7.0f, 7.0f), Random.Range(-4.0f, 4.0f));
        Instantiate(circle, position, Quaternion.identity);

        Invoke("SpawnCircle", spawnMin + Random.value * spawnVar);
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    void IncreaseDifficulty()
    {
        if(spawnMin + spawnInc > 0)
        {
            spawnMin += spawnInc;
        }

        Invoke("IncreaseDifficulty", 1f);
    }

    public void GameOver()
    {
        PlayerPrefs.SetInt("Score", score);
        Debug.Log("Game over!");
        SceneManager.LoadScene("gameover");
    }
}
