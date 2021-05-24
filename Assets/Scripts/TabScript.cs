using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TabScript : MonoBehaviour
{
    public GameObject icon;
    public Sprite iconSelected;
    public GameObject[] otherIcons;
    public Sprite[] otherIconsSelected;
    static public string lastPanelName = "home";
    public RectTransform[] Panels;
    public RectTransform actualPanel;
    RectTransform lastPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
        else
        {
            actualPanel.DOAnchorPos(Vector2.zero, 0.25f);
            lastPanel.DOAnchorPos(new Vector2(3500, 0), 0.25f);
        }

        icon.GetComponent<Image>().sprite = iconSelected;
        icon.GetComponentInChildren<Text>().color = new Color32(236, 199, 87, 255);

        for (var i = 0; i < otherIcons.Length; i++)
        {
            otherIcons[i].GetComponent<Image>().sprite = otherIconsSelected[i];
            otherIcons[i].GetComponentInChildren<Text>().color = Color.white;
        }

        lastPanelName = icon.name;
    }


}
