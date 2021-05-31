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
        HomeScript.etiquetes.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        //CanviarIdioma();
    }

    public void CanviarIdioma()
    {
        if (HomeScript.idioma=="CAT")
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
        else if (HomeScript.idioma == "SPA")
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
        else if (HomeScript.idioma == "ENG")
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
        else Debug.LogError("Idioma no trobat");
    }
}
