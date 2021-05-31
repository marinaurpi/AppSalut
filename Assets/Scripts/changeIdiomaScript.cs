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

    public void changeIdioma()
    {
        HomeScript.canviarIdioma(idiomaSelect.GetComponent<Text>().text);
    }
}
