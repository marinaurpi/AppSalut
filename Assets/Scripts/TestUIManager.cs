using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

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
        actualPage.DOAnchorPos(Vector2.zero, 0.25f);
        exitPage.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
    }
    public void goBack()
    {
        actualPage.DOAnchorPos(Vector2.zero, 0.25f);
        exitPage.DOAnchorPos(new Vector2(2000, 0), 0.25f);
    }
}
