using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{
    public string[] names = new string[10];

    public void Start(){
 for(int i = 0;i<10;i++)
        {
            string randomArrayString = names[Random.Range(0, names.Length)];
            Debug.Log(randomArrayString);
        }
}
}
