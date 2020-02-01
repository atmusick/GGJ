using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PercentSystem : MonoBehaviour
{
    // if chance is equal to or greater than 50, the player wins the tounament
    // if chance is lesse than 50, the player loses the tournament
   [Tooltip("put a tag on the text object for this")]
   public int chance;
   public AudioSource buttonClick;

   bool winState = true;


    void Success()
    {     
        if(chance>= 50)
        {
            Debug.Log("Player won!!");
            winState = true; //Makes the chances of losing higher
        }
        if(chance < 50)
        {
            Debug.Log("Player lost!!");
            winState = false; //Makes the chances of getting winning higher
        }
    }
      public void Check()
    {
        if (winState == false){
            chance = (Random.Range(1,101)+10); //If player wins 
        }else{
            chance = (Random.Range(1,101)-10);
        }
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) 
        {
            Success();
            Check();
        }
    } 
}
