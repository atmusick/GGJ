using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Leaderboard : MonoBehaviour
{
    public TextAsset randomNames;
    public string[] names = new string[10];
    public Text leaderboardText;
    [ContextMenu("Test some names")]
    public void Start()
    {
        SetRandomNames();
        UpdateTextWithNames();    
    }
    public void UpdateTextWithNames()
    {
        
        string leaderboardString = "";
        for(int i = 0;i<names.Length;i++)
        {
            // string randomArrayString = names[Random.Range(0, names.Length)];
            // Debug.Log(randomArrayString);
            leaderboardString = leaderboardString + (i+1)+". "+ names[i]+ "\n";
        }
        leaderboardText.text = leaderboardString;
    }
    
    void SetRandomNames()
    {
        string[] allNames = randomNames.text.Split('\n');
        for(int i = 0;i<5;i++){
            names[i] = allNames[Random.Range(0,allNames.Length)];
        }
    }
}