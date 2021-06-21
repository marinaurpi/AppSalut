using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TabScript : MonoBehaviour
{
    //icones del tab
    public GameObject[] Icons;
    //sprites de totes les icones quan estan seleccionades
    public Sprite[] IconsSelected;
    //sprites de totes les icones quan no estan seleccionades
    public Sprite[] IconsNotSelected;
    //tots els panels principal
    public RectTransform[] Panels;
    //panel actual
    public RectTransform actualPanel;
    //panel anterior
    RectTransform lastPanel;
    //variables estatiques per saber el panel actual i el anterior quan vulguis
    public static string tabActual = "home";
    static public string lastPanelName = "home";


    // Start is called before the first frame update
    void Start()
    {
        //codi per saber el index del panel actual
        var indexPanel = 0;
        for (var i = 0; i < Panels.Length; i++)
        {
            if (Panels[i].tag == tabActual)
            {
                Panels[i].gameObject.SetActive(true);
                Panels[i].DOAnchorPos(Vector2.zero, 0.25f);
                indexPanel = i;
            }
            else
            {
                Panels[i].gameObject.SetActive(false);
            }
        }
        for (var j = 0; j < Panels.Length; j++)
        {
            if (indexPanel > j)
            {
                Panels[j].DOAnchorPos(new Vector2(-3500, 0), 0.25f);
            }
            else if (indexPanel < j)
            {
                Panels[j].DOAnchorPos(new Vector2(3500, 0), 0.25f);
            }
        }
        for (var i = 0; i < Icons.Length; i++)
        {
            if (i==indexPanel)
            {
                Icons[i].GetComponent<Image>().sprite = IconsSelected[i];
                Icons[i].GetComponentInChildren<Text>().color = new Color32(236, 199, 87, 255);
                lastPanelName = Icons[i].name;
            }
            else
            {
                Icons[i].GetComponent<Image>().sprite = IconsNotSelected[i];
                Icons[i].GetComponentInChildren<Text>().color = Color.white;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    static public void tabActualActive(string lastPanelTab)
    {
        tabActual = lastPanelTab;
    }

    //funcio per poder fer les transicions corresponents entre els diferents panels principals
    public void buttonSelected()
    {
        var indexActual = 0;
        var indexLast = 0;
        for (var j = 0; j < Panels.Length; j++)
        {
            if (Panels[j].tag == lastPanelName)
            {
                lastPanel = Panels[j];
                indexLast = j;
            }
            if (Panels[j].tag == actualPanel.tag)
            {
                indexActual = j;
            }
        }

        lastPanel.gameObject.SetActive(false);
        actualPanel.gameObject.SetActive(true);

        if (indexActual>indexLast)
        {
            actualPanel.DOAnchorPos(Vector2.zero, 0.25f);
            lastPanel.DOAnchorPos(new Vector2(-3500, 0), 0.25f);
        }
        else if (indexActual < indexLast)
        {
            actualPanel.DOAnchorPos(Vector2.zero, 0.25f);
            lastPanel.DOAnchorPos(new Vector2(3500, 0), 0.25f);
        }

        for (var i = 0; i < Icons.Length; i++)
        {
            if (Icons[i].name == actualPanel.tag)
            {
                Icons[i].GetComponent<Image>().sprite = IconsSelected[i];
                Icons[i].GetComponentInChildren<Text>().color = new Color32(236, 199, 87, 255);
                lastPanelName = Icons[i].name;
            }
            else
            {
                Icons[i].GetComponent<Image>().sprite = IconsNotSelected[i];
                Icons[i].GetComponentInChildren<Text>().color = Color.white;
            }
        }

    }


}
