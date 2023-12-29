using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{ 
   public int scoreValue;

   private void OnCollisionEnter2D(Collision2D col)
   {
      if (col.gameObject.tag == "ObjetoPontuavel")
      {
         GameControler.instance.UpdateScore(scoreValue);
         

      }
      
   }
}
