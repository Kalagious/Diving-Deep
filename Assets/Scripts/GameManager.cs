using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{
   public GameObject player;
   public TextMeshProUGUI score_text;


   private int player_health;
   private int player_score;

   void Start(){
      player_score = 0;
      //Start score at zero
      score_text.text = "Score: " + player_score;
   }

   public void AddScore(int gotpoints)
   {
      //Add points
      player_score += gotpoints;
      //Add points to score text
      score_text.text = "Score: " + player_score + "/7";
        if (player_score == 7)
        {
            SceneManager.LoadScene("VictoryScreen");
        }

    }

   void Update(){
      
      if(Input.GetKey(KeyCode.Escape)){
         Application.Quit();
      }
      if(Input.GetKeyDown(KeyCode.Space)){
      }
   }
}