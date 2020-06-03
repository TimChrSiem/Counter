using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    private int score = 0;
    private Text textComponent;
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<Text>();
        Cube = GameObject.FindGameObjectWithTag("TriggerZone"); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TriggerZone")
        {
            score += 1;
        }
    }
    void Update()
    {
       
        textComponent.text = "Palleten im LKW:" + score; 
    }
}
    