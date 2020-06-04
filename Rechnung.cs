using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Rechnung : MonoBehaviour
{
    public GameObject CubeObject;
    private GameObject EmptyGameobject;
    private GameObject clone;
    private GameObject theRechnung;
    private LKW lkw;
  

    private void Awake()
    {
        lkw = GameObject.FindObjectOfType<LKW>();
       
    }
    // Update is called once per frame
    private void Update()

    {
        
        int waren = lkw.getInhaltCount(); 
        if (waren >=5)
        {
            if (theRechnung == null) 
            {

                theRechnung = Instantiate(CubeObject, transform.position, transform.rotation);
            } 
            else 
            {
                return;
            }
        }
        else if  (waren < 5)
        {
            clone = GameObject.FindGameObjectWithTag("Rechnung");
            DestroyImmediate(clone,true);


        }



    }
}
