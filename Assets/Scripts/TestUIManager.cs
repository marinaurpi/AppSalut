using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

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


    public void goNext()
    {
        selectOneOptionScript.getValue();

        if (selectOneOptionScript.selected == true && exitPage.tag == "onlyOneOption")
        {
            actualPage.DOAnchorPos(Vector2.zero, 0.25f);
            exitPage.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
            selectOneOptionScript.setValue(false);
        }
        else if (exitPage.tag  == "multipleOptions")
        {
            actualPage.DOAnchorPos(Vector2.zero, 0.25f);
            exitPage.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
        }

    }

    public void goBack()
    {
            actualPage.DOAnchorPos(Vector2.zero, 0.25f);
            exitPage.DOAnchorPos(new Vector2(2000, 0), 0.25f);
        if (actualPage.tag == "onlyOneOption")
        {
            selectOneOptionScript.setValue(true);
        }
        
    }
}
