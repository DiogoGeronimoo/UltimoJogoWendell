using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public Text GolContadorText;
    public int score;
    public Text ScoreText;
    public static GameControler instance;
    public int Gol;

    void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        
    }

    public void UpdateScore(int value)
    {
        score += value;
        ScoreText.text = score.ToString();

    }



    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Gol")
        {
            
        }
    }

    public void UpdateLives(int value)
    {
        GolContadorText.text = "X" + value.ToString();
    }
}
