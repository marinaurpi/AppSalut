using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class changePanelScript : MonoBehaviour
{
    public RectTransform actualPanel;
    public RectTransform[] Panels;
    static public string lastPanelName = "ansietatPanel";
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
    public void goNext()
    {
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

        actualText.color = new Color32(236, 199, 87, 255);
        actualText.font = actualFont;

        for (var i = 0; i < otherText.Length; i++)
        {
            otherText[i].color = Color.black;
            otherText[i].font = otherFont;
        }

        lastPanelName = actualPanel.name;

    }

    public void goBack()
    {
        actualPanel.DOAnchorPos(Vector2.zero, 0.25f);

    }
}
