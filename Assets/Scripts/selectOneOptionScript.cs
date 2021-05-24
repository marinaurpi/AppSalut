using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class selectOneOptionScript : MonoBehaviour
{
    public GameObject[] respostes;
    public GameObject res;
    static public bool selected;
    bool selectOption;
    static public GameObject[] respostesSelected;

    // Start is called before the first frame update
    void Start()
    {
        respostesSelected = respostes;
        selectOption = false;
        selected = selectOption;
        print(selected);
    }

    // Update is called once per frame
    void Update()
    {
        print(selected);
    }
    public void selectResposta()
    {
        for (var i = 0; i < respostes.Length; i++)
        {
            if (respostes[i].active == true)
            {
                respostes[i].SetActive(false);
            }
        }
        res.SetActive(true);
        selectOption = true;
        selected = selectOption;
        
    }

    static public void setValue(bool select)
    {
        selected = select;
    }
}
