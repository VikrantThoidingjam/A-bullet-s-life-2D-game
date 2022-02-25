using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;
    private void Update()
    {
        scoreDisplay.text = score.ToString();
        if (score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("obstacle"))
        {
            score++;
            Debug.Log(score);
        }
    }
}
