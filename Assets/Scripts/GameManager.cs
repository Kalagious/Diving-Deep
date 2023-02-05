using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour{

   void Start(){

   }
   void Update(){
      if(Input.GetKey(KeyCode.Escape)){
         Application.Quit();
      }
      if(Input.GetKeyDown(KeyCode.Space)){
         TogglePause();
      }
   }


}