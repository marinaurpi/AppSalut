using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class changePanelScript : MonoBehaviour
{
    //panel actual de la barra de navegació superior
    public RectTransform actualPanel;
    //tots els panels de la barra de navegació superior
    public RectTransform[] Panels;
    //ultim panel on estava
    static public string lastPanelName= "ansietatPanel";
    RectTransform lastPanel;
    //text actual de la barra de navegació superior
    public Text actualText;
    //tots els texts de la barra de navegació superior
    public Text[] otherText;
    //tipografia del text seleccionat de la barra de navegació superior
    public Font actualFont;
    //tipografia del text no seleccionat de la barra de navegació superior
    public Font otherFont;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Per poder fer les transicions correctement dels panels dins de la barra de navegació superior quan esta compost per més de dos sub-panels
    public void goNextOrdre()
    {
        actualPanel.gameObject.SetActive(true);

        var indexActual = 0;
        var indexLast = 0;
         
        for (var j = 0; j < Panels.Length; j++)
        {

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
