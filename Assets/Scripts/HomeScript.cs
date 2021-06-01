using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class HomeScript : MonoBehaviour
{
    public static bool welcomeActive = true;
    public GameObject welcome, test1;
    public GameObject avatar;
    public GameObject fons;
    public Texture[] fonsTexture;
    public Texture[] avatarTexture;

    /*public static List<TraduccioScript> etiquetes = new List<TraduccioScript>();
    public static string idioma;*/

    // Start is called before the first frame update
    void Start()
    {
        print("Fons: "+UserOptionManager.fons);
        print("Avatar: " + UserOptionManager.avatar);
        fons.GetComponent<RawImage>().texture = fonsTexture[UserOptionManager.fons];
        avatar.GetComponent<RawImage>().texture = avatarTexture[UserOptionManager.avatar];

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
