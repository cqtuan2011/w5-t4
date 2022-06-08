using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverPanel : MonoBehaviour
{
    public TextMeshProUGUI playerScore;
    public TextMeshProUGUI highestScore;
    private void Start()
    {
        Cursor.visible = true;
        Debug.Log("GameOverPnal is running!");
    }
    void Update()
    {
        playerScore.text = ScoreScript.scoreValue.ToString();
        highestScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void PlayAgain() // Button
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ResetButton() // Button 
    {
        PlayerPrefs.DeleteKey("HighScore");
        highestScore.text = "0";
    }
}
