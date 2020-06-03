using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class OtherScript : MonoBehaviour
{
    private int Beleg = 0 ;
    public GameObject CubeObject;
    private int score = 0;
    private Text textComponent;
    private GameObject[] Paletten;
    private Rechnung rechnung;
    private void Start()
    {
        Paletten = GameObject.FindGameObjectsWithTag("Palette");
        foreach (GameObject palette in Paletten)
        textComponent = GetComponent<Text>();
    }

    private void Awake()
    {
        rechnung = GameObject.FindObjectOfType<Rechnung> ();
    }

    public void Update()
    {
        rechnung.UpdateBeleg(Beleg);
        
        int n = 0;
        
        Paletten = GameObject.FindGameObjectsWithTag("Palette");
        foreach (GameObject palette in Paletten)
        {


            if(palette.GetComponent<Palette>().EnterdTrigger)

            {

                n = n + 1;
                score = n;
                textComponent.text = "Paletten im LKW : " + score;

            }
            else
            {
                
                n = n - 1;
                score = n ;
                textComponent.text = "Paletten im LKW : " + score;
            }
 

            
        }   
      
        
        if (score >= 5)
        {
           Beleg = 1;
            
        }
        else
        {
            Beleg = 0;
        }
    }
}