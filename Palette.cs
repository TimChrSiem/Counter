using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Palette : MonoBehaviour
{
    public bool EnterdTrigger;
    public bool LeaveTrigger;
   
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TriggerZone")
        
        {
            EnterdTrigger = true;
           
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag =="Triggezone")
        {
            EnterdTrigger = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



  