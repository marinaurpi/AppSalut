using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectOneOptionScript : MonoBehaviour
{
    //Array de totes les opcions possibles
    public GameObject[] respostes;
    //Opcio seleccionada
    public GameObject res;
    //variable estatica per saber si hi ha alguna opcio seleccionada o no
    static public bool selected;

    bool selectOption;
    static public GameObject[] respostesSelected;

    // Start is called before the first frame update
    void Start()
    {
        selectOption = false;
        selected = selectOption;
        respostesSelected = respostes;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void selectResposta()
    {
        //loop per desctivar el check de totes les opcions que no estan seleccionades
        for (var i = 0; i < respostes.Length; i++)
        {
            if (respostes[i].active == true)
            {
                respostes[i].SetActive(false);
            }
        }
        //activar l'opcio seleccionda
        res.SetActive(true);
        selectOption = true;
        selected = selectOption;
        
    }

    //funcio estatica per canviar el valor de la variable estatica selected
    static public void setValue(bool select)
    {
        selected = select;
    }
}
