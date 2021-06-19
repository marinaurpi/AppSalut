using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFinsihScript : MonoBehaviour
{
    //ultim panel del tab en qual l'usuari estava abans d'anar a una altre escena
    public string lastPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //funció per posar el valor del panel actual dins del script TabScript
    public void changePanel()
    {
        TabScript.tabActualActive(lastPanel);
    }
}
