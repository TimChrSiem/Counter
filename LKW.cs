using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LKW : MonoBehaviour
{
    private List<GameObject> inhalt = new List<GameObject>() ;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Palette")
        {
            inhalt.Add(other.gameObject);
           // Debug.Log(inhalt.Count);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Palette")
        {
            inhalt.Remove(other.gameObject);
          //  Debug.Log(inhalt.Count);
        }
    }
    public int getInhaltCount()
    {
        return inhalt.Count;
            
    }
   
}
