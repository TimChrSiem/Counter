using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Rechnung : MonoBehaviour
{
    public GameObject CubeObject;
    private GameObject EmptyGameobject;
    private int f = 0;
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
        
        {
            if (theRechnung == null) {
                theRechnung = Instantiate(CubeObject, transform.position, transform.rotation);
            } else {
                return;
            }
        }
        else if  (f==0)
        {
            Destroy(CubeObject);


        }



    }
}
