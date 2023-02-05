using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour{
   public GameObject player;


   private int player_health;
   private int player_score;

   void Start(){

   }
   void Update(){
      if(Input.GetKey(KeyCode.Escape)){
         Application.Quit();
      }
      if(Input.GetKeyDown(KeyCode.Space)){
      }
   }
}