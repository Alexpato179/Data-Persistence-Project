using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIMenuHandler : MonoBehaviour
{
    public string playername;
    public InputField InputUser;
    public TextMeshProUGUI Score;

    void Start()
    {


    }
    public void StartButton()
    {
        playername = InputUser.text;

        if (playername != null)
        {
            Bridge.Name = playername;
            SceneManager.LoadScene("main");
            gameObject.SetActive(false);
        }

    }


    public void ExitButton()
    {

        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();


    }
    public void ShowHighScore()
    {
        Bridge.LoadScoreData();
        if (Bridge.HighScoreName != null)
        {
            Score.text = "HIGHSCORE : " + Bridge.HighScoreName + " " + Bridge.HighScore;
        }
    }

}
