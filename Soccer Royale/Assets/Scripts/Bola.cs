using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float Speed;
    public int ForcaBola;
    private Vector2 posicaoInicial;
    public float forcaQuicada = 5f;
    public float fatorReducao;
    public Rigidbody2D rb;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Se o objeto colidir com uma parede, inverte a velocidade na direção da normal da colisão.
        if (collision.gameObject.CompareTag("Parede"))
        {
            Vector2 normal = collision.contacts[0].normal;
            rb.velocity = Vector2.Reflect(rb.velocity, normal) * fatorReducao;
        }
    }
    

    public Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("Trave"))
        {
            posicaoInicial = transform.position;
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
