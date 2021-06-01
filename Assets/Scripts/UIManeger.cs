using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManeger : MonoBehaviour
{
    public RectTransform login, register;
    public GameObject snap, toogle;
    public static List<TraduccioScript> etiquetes = new List<TraduccioScript>();
    public static string idioma;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void activeCanviarIdioma(string lang)
    {
        idioma = lang;
        for (var i = 0; i < etiquetes.Count; i++)
        {
            etiquetes[i].CanviarIdioma();
        }

    }
    public void goLogin()
    {
        snap.SetActive(false);
        toogle.SetActive(false);
        login.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void goRegister()
    {
        snap.SetActive(false);
        toogle.SetActive(false);
        register.DOAnchorPos(Vector2.zero, 0.25f);
    }

    public void goRegister2()
    {
        register.DOAnchorPos(Vector2.zero, 0.25f);
        login.DOAnchorPos(new Vector2(0, 6575), 0.25f);
    }

    public void goLogin2()
    {
        login.DOAnchorPos(Vector2.zero, 0.25f);
        register.DOAnchorPos(new Vector2(0, -6575), 0.25f);
    }

}
