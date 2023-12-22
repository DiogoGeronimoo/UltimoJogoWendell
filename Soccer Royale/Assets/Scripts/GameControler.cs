using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;

public class GameControler : MonoBehaviour
{
    public int pontos = 0;
    public Text GolContadorText;
    public int score;
    public Text ScoreText;
    public static GameControler instance;
    
    

    void Awake()
    {
        instance = this;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifique se o objeto colidido tem a tag "ObjetoPontuavel".
        if (collision.gameObject.CompareTag("ObjetoPontuavel"))
        {
            AdcionarPontos(1); // Incrementa o contador de pontos.
            Destroy(collision.gameObject); // Destroi o objeto colidido, se desejado.
        }
    }

    public void AdcionarPontos(int pontosGanho)
    {
        pontos += pontosGanho;

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
        if (col.gameObject.tag == "Bola")
        {
            

        }
    }

    public void UpdateLives(int value)
    {
        GolContadorText.text = "Gol" + value.ToString();
    }
}
