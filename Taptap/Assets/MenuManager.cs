using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public Text highscore;

    private void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void StartButtonClicked()
    {
        SceneManager.LoadScene("main");
    }

    public void ExitButtonClicked()
    {
        Application.Quit();
    }
}
