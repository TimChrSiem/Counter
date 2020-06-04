using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textboxscript : MonoBehaviour
{
    private Text textComponent; 
    private LKW lkw;
    private void Awake()
    {
        lkw = GameObject.FindObjectOfType<LKW>(); 
    }

    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<Text>();
    }

    
    void Update()
    {
        int score = lkw.getInhaltCount();
        textComponent.text = "Paletten im Lkw : " + score; 
    }
}
