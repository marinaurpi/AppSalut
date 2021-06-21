using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpProfileScript : MonoBehaviour
{
    //panel del ProfilePopUp
    public GameObject popup;
    //tots els components dins de ProfilePopUp 
    public GameObject[] panelsChangeValue;
    //bool per saber si es necessita contrassenya o no per canviar el camp
    public bool ambContrassenya;
    public static bool contrassenyaActive;
    //GameObject dels diferents components de la contrassenya del pop-up seleccionat
    public GameObject contrassenya;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //funcio per activar el pop-up depenent de la camp que vol canviar
    public void changeValue()
    {
        contrassenyaActive = ambContrassenya;
        if (ambContrassenya)
        {
            contrassenya.SetActive(true);
        }
        else
        {
            contrassenya.SetActive(false);
        }
        popup.SetActive(true);
        for (var i = 0; i < panelsChangeValue.Length; i++)
        {
            if (panelsChangeValue[i].name == this.name)
            {
                panelsChangeValue[i].SetActive(true);
            }
        }
    }
}
