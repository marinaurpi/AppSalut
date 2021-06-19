using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;
using System.ComponentModel.Design;

public class TestUIManager : MonoBehaviour
{
    //panels d'entrada i de sortida per poder fer les transicions corresponnets
    public RectTransform exitPage, actualPage;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //funcio per anar al següent panel
    public void goNext()
    {
        //si és un panel on nomes pots escollir una opció i hi ha alguna opcio seleccionada
        if (selectOneOptionScript.selected == true && exitPage.tag == "onlyOneOption")
        {
            actualPage.gameObject.SetActive(true);
            actualPage.DOAnchorPos(Vector2.zero, 0.25f);
            exitPage.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
        }
        //si és un panel on es poden escollir més d'una opció
        else if (exitPage.tag == "multipleOptions")
        {
            actualPage.gameObject.SetActive(true);
            actualPage.DOAnchorPos(Vector2.zero, 0.25f);
            exitPage.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
        }
        //si és un panel on nomes pots escollir una opció i no hi ha cap opcio seleccionada
        else
        {
            Debug.LogWarning("Selecciona un dels botons per poder seguir.");
        }

    }

    //funcio per anar al panel anterior
    public void goBack()
    {
        selectOneOptionScript.setValue(true);
        actualPage.DOAnchorPos(Vector2.zero, 0.25f);
        exitPage.DOAnchorPos(new Vector2(2000, 0), 0.25f);
        
    }
}
