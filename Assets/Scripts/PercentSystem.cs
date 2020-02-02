using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PercentSystem : MonoBehaviour
{
    // if chance is equal to or greater than 50, the player wins the tounament
    // if chance is lesse than 50, the player loses the tournament
   [Tooltip("put a tag on the text object for this")]
   public int chance;
   public AudioSource buttonClick;

   bool winState = true;
   //
   public GameObject PanelOne;
   public GameObject PanelTwo;

   public void Success()
    {     
        if(chance>= 50)
        {
            winState = true; //Makes the chances of losing higher
            //TextBox.GetComponent<Text>().text = "You Won!";
            if(PanelOne !=null)
            {
                bool isActive = PanelOne.activeSelf;   
                PanelOne.SetActive(!isActive);  
            }
        //////////////////////////////////////////////////////////////////////
        }
        if(chance < 50)
        {
            winState = false; //Makes the chances of getting winning higher
            //TextBox.GetComponent<Text>().text = "You Lost!";
             if(PanelTwo !=null)
            {
                bool isActive = PanelTwo.activeSelf;
                PanelTwo.SetActive(isActive);
            }
        }
        ////////////////////////////////////////////////////////////////////
         if (winState == false){
            chance = (Random.Range(1,101)+10); //If player wins 
        }else{
            chance = (Random.Range(1,101)-10);
        }
        ////////////////////////////////////////////////////////////////////
    }
}
