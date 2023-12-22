using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoQuicante : MonoBehaviour
{
    private Rigidbody2D rb;
    public float forcaQuicar = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto colidiu com uma parede (ou qualquer outra coisa que você deseja que faça quicar).
        if (collision.gameObject.CompareTag("Parede"))
        {
            // Inverte a velocidade na direção em que ocorreu a colisão.
            Vector2 normalDaColisao = collision.contacts[0].normal;
            Vector2 reflexao = Vector2.Reflect(rb.velocity, normalDaColisao).normalized;

            // Aplica a reflexão à velocidade para quicar.
            rb.velocity = reflexao * forcaQuicar;
        }
    }
}
