using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 throwVector;
    private Rigidbody2D rig;
    private LineRenderer lrd;
    public float forcaQuicada = 5f;
    public float fatorReducao;
   

    void Awake()
    {
        rig = this.GetComponent<Rigidbody2D>();
        lrd = this.GetComponent<LineRenderer>();
    }

    private void OnMouseDown()
    {
        CalculateThrowVector();
        SetArrow();
    }

    private void OnMouseDrag()
    {
        CalculateThrowVector();
        SetArrow();
    }

    void CalculateThrowVector()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 distance = mousePos - this.transform.position;
        throwVector =-distance.normalized * 100;
    }

    void SetArrow()
    {
        lrd.positionCount = 2;
        lrd.SetPosition(0,Vector3.zero);
        lrd.SetPosition(1,throwVector.normalized/2);
        lrd.enabled = true;
    }

    private void OnMouseUp()
    {
        RemoveArrow();
        Throw();
    }

    void RemoveArrow()
    {
        lrd.enabled = false;
    }

    public void Throw()
    {
        rig.AddForce(throwVector);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Se o objeto colidir com uma parede, inverte a velocidade na direção da normal da colisão.
        if (collision.gameObject.CompareTag("Parede"))
        {
            Vector2 normal = collision.contacts[0].normal;
            rig.velocity = Vector2.Reflect(rig.velocity, normal) * fatorReducao;
        }
    }

    //abaixo nao serve
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
