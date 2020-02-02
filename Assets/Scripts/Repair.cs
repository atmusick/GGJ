using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repair : MonoBehaviour
{
    public GameObject button;
    public SpriteRenderer sr;
    // Start is called before the first frame update

    public void Fix()
    {
        button.SetActive(true);
    }
    
}
