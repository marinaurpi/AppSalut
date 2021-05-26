using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class ProfileUIManager : MonoBehaviour
{
    public RectTransform exitPanel, actualPanel;
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
        actualPanel.DOAnchorPos(Vector2.zero, 0.25f);
        exitPanel.DOAnchorPos(new Vector2(-3500, 0), 0.25f);

    }

    public void goBack()
    {
        actualPanel.DOAnchorPos(Vector2.zero, 0.25f);
        exitPanel.DOAnchorPos(new Vector2(3500, 0), 0.25f);

    }
}
