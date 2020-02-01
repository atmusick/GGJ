using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PercentSystem : MonoBehaviour
{
    // if chance is equal to or greater than 50, the player wins the tounament
    // if chance is lesse than 50, the player loses the tournament
   [Tooltip("put a tag on the text object for this")]
   public int chance;

    void Success()
    {     
        if(chance>= 50)
        {
            Debug.Log("Player won!!");
        }
        if(chance < 50)
        {
            Debug.Log("Player lost!!");
        }
    }
      public void Check()
    {
        chance = Random.Range(1,101);
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
