using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;

public class GameControler : MonoBehaviour
{
    public int pontos = 0;
    public int pontos1 = 0;
    public Text GolContadorText;
    public Text GolContadorText1;
    public int score;
    public int score1;
    public Text ScoreText;
    public Text ScoreText1;
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
            AdcionarPontos(1, "vermelho"); // Incrementa o contador de pontos.
            Destroy(collision.gameObject); // Destroi o objeto colidido, se desejado.
        }

        if (collision.gameObject.CompareTag("ObjetoPontuavel1"))
        {
            AdcionarPontos(1, "azul"); // Incrementa o contador de pontos.
            Destroy(collision.gameObject); // Destroi o objeto colidido, se desejado.
        }
    }

    public void AdcionarPontos(int pontosGanho, string cordogol)
    {
        if (cordogol == "azul")
        {
            pontos += pontosGanho;
            
        }

        if (cordogol == "vermelho")
        {
            pontos1 += pontosGanho;
        }

    }

    private void Update()
    {

    }

    public void UpdateScore(int value)
    {
        score += value;
        ScoreText.text = score.ToString();

    }

    public void UpdateScore1(int value1)
    {
        ScoreText1.text = score1.ToString();
        score1 += value1;
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
        GolContadorText1.text = "Gol1" + value.ToString();
    }
} 
