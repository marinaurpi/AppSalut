using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TraduccioScript : MonoBehaviour
{
    public string catala;
    public string castella;
    public string ingles;
    public bool isButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CanviarIdioma();
    }

    public void CanviarIdioma()
    {
        if (HomeScript.idioma=="Català")
        {
            if (isButton)
            {
                GetComponentInChildren<Text>().text = catala;
            }
            else
            {
                GetComponent<Text>().text = catala;
            }
        }
        if (HomeScript.idioma == "Castellà")
        {
            if (isButton)
            {
                GetComponentInChildren<Text>().text = castella;
            }
            else
            {
                GetComponent<Text>().text = castella;
            }
        }
        if (HomeScript.idioma == "Anglès")
        {
            if (isButton)
            {
                GetComponentInChildren<Text>().text = castella;
            }
            else
            {
                GetComponent<Text>().text = ingles;
            }
        }
    }
}
