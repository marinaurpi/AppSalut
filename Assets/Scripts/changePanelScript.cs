using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class changePanelScript : MonoBehaviour
{
    public RectTransform actualPanel;
    public RectTransform[] Panels;
    static public string lastPanelName= "ansietatPanel";
    RectTransform lastPanel;
    public Text actualText;
    public Text[] otherText;
    public Font actualFont;
    public Font otherFont;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goNextOrdre()
    {
        actualPanel.gameObject.SetActive(true);

        var indexActual = 0;
        var indexLast = 0;
         
            for (var j = 0; j < Panels.Length; j++)
            {
            /*if (lastPanelName == ""){
                if (Panels[j].name == "missionsPanel")
                {
                    lastPanel = Panels[j];
                    indexLast = j;
                }
                else if (Panels[j].name == "ansietatPanel")
                {
                    lastPanel = Panels[j];
                    indexLast = j;
                }
                else if (Panels[j].name == "configuracioPanel")
                {
                    lastPanel = Panels[j];
                    indexLast = j;
                }

            }
            else
            {
                if (Panels[j].name == lastPanelName)
                {
                    lastPanel = Panels[j];
                    indexLast = j;
                }
            }*/

            if (Panels[j].name == lastPanelName)
            {
                lastPanel = Panels[j];
                indexLast = j;
            }

            if (Panels[j].name == actualPanel.name)
                {
                    indexActual = j;
                }
            

            if (indexActual > indexLast)
            {
                actualPanel.DOAnchorPos(Vector2.zero, 0.25f);
                lastPanel.DOAnchorPos(new Vector2(-3500, 0), 0.25f);
            }
            else
            {
                actualPanel.DOAnchorPos(Vector2.zero, 0.25f);
                lastPanel.DOAnchorPos(new Vector2(3500, 0), 0.25f);
            }
        }

        actualText.color = new Color32(236, 199, 87, 255);
        actualText.font = actualFont;

        for (var i = 0; i < otherText.Length; i++)
        {
            otherText[i].color = Color.white;
            otherText[i].font = otherFont;
        }

        lastPanel.gameObject.SetActive(false);
        lastPanelName = actualPanel.name;

    }

    public void goNext()
    {
        actualPanel.gameObject.SetActive(true);
        actualPanel.DOAnchorPos(Vector2.zero, 0.25f);
        Panels[0].DOAnchorPos(new Vector2(-3500, 0), 0.25f);
        Panels[0].gameObject.SetActive(false);

        actualText.color = new Color32(236, 199, 87, 255);
        actualText.font = actualFont;

        for (var i = 0; i < otherText.Length; i++)
        {
            otherText[i].color = Color.white;
            otherText[i].font = otherFont;
        }

    }

    public void goBack()
    {
        actualPanel.gameObject.SetActive(true);
        actualPanel.DOAnchorPos(Vector2.zero, 0.25f);
        Panels[1].DOAnchorPos(new Vector2(3500, 0), 0.25f);
        Panels[1].gameObject.SetActive(false);

        actualText.color = new Color32(236, 199, 87, 255);
        actualText.font = actualFont;

        for (var i = 0; i < otherText.Length; i++)
        {
            otherText[i].color = Color.white;
            otherText[i].font = otherFont;
        }

    }
}
