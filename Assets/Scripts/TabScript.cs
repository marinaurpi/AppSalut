using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TabScript : MonoBehaviour
{
    public GameObject[] Icons;
    public Sprite[] IconsSelected;
    public Sprite[] IconsNotSelected;
    static public string lastPanelName = "home";
    public RectTransform[] Panels;
    public RectTransform actualPanel;
    RectTransform lastPanel;
    public static string tabActual = "home";


    // Start is called before the first frame update
    void Start()
    {
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
