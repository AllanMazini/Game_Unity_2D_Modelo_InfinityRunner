using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int Score;
    public int CoinScore;
    public float ScorePerSecund;

    public Button Restart;
    public GameObject PainelGameOver;
    public bool PlayerIsAlive;
    public Text coinText;

    public Text scoreText;
    public static GameController current;


    // Start is called before the first frame update
    void Start()
    {   
        PlayerIsAlive = true;
        current = this;
    }

    // Update is called once per frame
    float ScoreToFloat;
    void Update()
    {

        if(PlayerIsAlive)
        {
            ScoreToFloat += ScorePerSecund * Time.deltaTime;
            Score = (int)ScoreToFloat;

            scoreText.text = Score.ToString();
        }


    }
    public void AddScore(int value)
    {
        CoinScore += value;
        coinText.text = CoinScore.ToString();
    }

    public void RestartButton(){
        SceneManager.LoadScene(0);
    }

    public void ClosedButton(){

        Application.Quit();
    }

}
