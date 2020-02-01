//Holds all of the systems for our the cash system
//Including Current Cash, cost of mods/repairs, and cashout rewards
//Scripted by: Christopher Brinkley
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySystem : MonoBehaviour
{
    public int currentMoney = 200, baseRewardMoney, rewardMoney, modMoney, repairMoney, illegalMoney;

    public int repairPercentage; //REMOVE WHEN CONNECTED WITH CONTROLLER
    bool Mods = true; //REMOVE WHEN CONNECTED WITH CONTROLLER
    bool illegalMods =true; //REMOVE WHEN CONNECTED WITH CONTROLLER

    void Update()
    {

    }

    public void Prices(){
        repairMoney = /*repair percentage here */0; //Place the Repair percentage in this spot!!!

        baseRewardMoney = (Random.Range(50,100)); //Sets the range of the base reward between $50-100

        modMoney = (Random.Range(50,150)); //Sets the Modification cost between $50-150

        illegalMoney = (Random.Range(75,200)); //Sets the illegal modification cost between $75-200

    }

    void repairMoneyReward(){ //System for adding or subtracting the reward money from the player in the results screen
         if (repairMoney <= 50){
            rewardMoney= (Random.Range(50, 100)); //Sets the repair money between $50-100 if the total repair cost is <50%)
        }else if (repairMoney >= 51 && repairMoney <= 100){
            rewardMoney = (Random.Range(100, 150)); //Sets the repair money between $100-150 if the total repair cost is $50-100
        }else if (repairMoney >=101){
            rewardMoney= (Random.Range(150, 200)); //Sets the repair reward between $150-200 if the total repair cost is >$100
        }

    }
    
    public void Successreward(){
        currentMoney += (baseRewardMoney + rewardMoney); //Adds the base reward + repair money to reward
        if(illegalMods == true){ //Place illegal mods Booleen here!!!
            currentMoney += (illegalMoney *2); //Adds the illegal mod money to reward 
        }
        if(Mods == true){ //Place Mod booleen here!
            currentMoney += modMoney; //Adds the Mod money to reward
        }

    }

    public void Failurereward(){
        currentMoney += (baseRewardMoney + ( rewardMoney * (1/2)));
        if(illegalMods == true){ //Place Illegal mods booleen here!!!!
            currentMoney -= illegalMoney; //subtractst the illegal money from the  
        }

    }
    

    void Resetmoney(){
        currentMoney = 200;
    }
}
