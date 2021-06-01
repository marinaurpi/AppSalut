using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;
using System.ComponentModel.Design;

public class TestUIManager : MonoBehaviour
{
    public RectTransform exitPage, actualPage;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Arreglar funcions de transicions per a que les opcions uniques es seleccioni alguna opcio obligatoriament abans de fer next i que quan tornin en radera estigui en true
    public void goNext()
    {
        //print(selectOneOptionScript.selected);
        if (selectOneOptionScript.selected == true && exitPage.tag == "onlyOneOption")
        {
            actualPage.gameObject.SetActive(true);
            actualPage.DOAnchorPos(Vector2.zero, 0.25f);
            exitPage.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
            //selectOneOptionScript.setValue(false);
        }
        else if (exitPage.tag == "multipleOptions")
        {
            actualPage.gameObject.SetActive(true);
            actualPage.DOAnchorPos(Vector2.zero, 0.25f);
            exitPage.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
        }
        else
        {
            Debug.LogWarning("Selecciona un dels botons per poder seguir.");
        }

    }

    public void goBack()
    {
        selectOneOptionScript.setValue(true);
        actualPage.DOAnchorPos(Vector2.zero, 0.25f);
        exitPage.DOAnchorPos(new Vector2(2000, 0), 0.25f);
        
    }
}
