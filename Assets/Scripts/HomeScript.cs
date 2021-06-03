using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class HomeScript : MonoBehaviour
{
    public static bool welcomeActive = true;
    public GameObject welcome, test1;
    public GameObject[] avatar;
    public GameObject[] fons;
    public Texture[] fonsTexture;
    public Texture[] avatarTexture;
    public GameObject[] animEco;

    /*public static List<TraduccioScript> etiquetes = new List<TraduccioScript>();
    public static string idioma;*/

    // Start is called before the first frame update
    void Start()
    {
        print("Fons: "+UserOptionManager.fons);
        print("Avatar: " + UserOptionManager.avatar);
        for (var i= 0; i<fons.Length; i++)
        {
            fons[i].GetComponent<RawImage>().texture = fonsTexture[UserOptionManager.fons];
        }
        for (var j = 0; j < avatar.Length; j++)
        {
            avatar[j].GetComponent<RawImage>().texture = avatarTexture[UserOptionManager.avatar];
        }

        //Codi per anima l'avatar
        if (UserOptionManager.avatar==2)
        {
            animEco[0].SetActive(true);
            animEco[1].SetActive(true);
            avatar[1].SetActive(false);
            avatar[2].SetActive(false);
        }
        

        if (welcomeActive)
        {
            welcome.SetActive(true);
        }
        else
        {
            welcome.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void welcomeState()
    {
        welcome.SetActive(false);
        welcomeActive = false;
    }

    public void test1State()
    {
        test1.SetActive(true);
    }
}
