using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    private Vector3 throwVector;
    private Rigidbody2D rig;
    private LineRenderer lrd;

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

    void CalculateThrowVector()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 distance = mousePos - this.transform.position;
        throwVector = -distance.normalized * 100;
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

    //abaixo nao serve
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
