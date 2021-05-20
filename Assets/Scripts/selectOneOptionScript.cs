using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectOneOptionScript : MonoBehaviour
{
    public GameObject[] respostes;
    public GameObject res;
    static public bool selected = false;
    static public GameObject[] respostesSelected;

    // Start is called before the first frame update
    void Start()
    {
        selected = false;
        respostesSelected = respostes;
    }

    // Update is called once per frame
    void Update()
    {
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
        selected = true;
    }

    static public void setValue(bool select)
    {
        selected = select;
    }
    static public void getValue()
    {
        for (var i = 0; i < respostesSelected.Length; i++)
        {
            if (respostesSelected[i].active == true)
            {
                selected = true;
            }
        }
    }
}
