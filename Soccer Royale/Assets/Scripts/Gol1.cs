using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol1 : MonoBehaviour
{ 
    public int scoreValue1;
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ObjetoPontuavel1")
        {
            GameControler.instance.UpdateScore1(scoreValue1);
         

        }
      
    }
}
