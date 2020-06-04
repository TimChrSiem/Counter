using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Rechnung : MonoBehaviour
{
    public GameObject CubeObject;
    private GameObject EmptyGameobject;
    private GameObject Text;
    public OtherScript Beleg;
    private int f = 0;
    private GameObject theRechnung;


    // Update is called once per frame
    public  void UpdateBeleg(int Beleg)
    {
        f = Beleg ;
        if (f == 1)
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
