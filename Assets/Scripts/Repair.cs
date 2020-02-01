using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repair : MonoBehaviour
{
    public GameObject button;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
    }

    public void Fix()
    {
        button.SetActive(true);
    }
    
}
