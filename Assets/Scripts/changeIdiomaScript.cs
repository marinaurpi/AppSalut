using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeIdiomaScript : MonoBehaviour
{
    public GameObject idiomaSelect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //funcio per canviar l'idioma dins del pop-up
    public void changeIdioma()
    {
        string[] lang = new string[] { "CAT", "SPA", "ENG" };
        int index = idiomaSelect.GetComponent<Dropdown>().value;
        UIManeger.activeCanviarIdioma(lang[index]);
    }
}
