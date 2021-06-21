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


    // Start is called before the first frame update
    void Start()
    {
        //codi per aplicar l'avatar i el fons seleccionat
        for (var i= 0; i<fons.Length; i++)
        {
            fons[i].GetComponent<RawImage>().texture = fonsTexture[UserOptionManager.fons];
        }
        for (var j = 0; j < avatar.Length; j++)
        {
            avatar[j].GetComponent<RawImage>().texture = avatarTexture[UserOptionManager.avatar];
        }

        //Codi per animar l'avatar
        if (UserOptionManager.avatar==2)
        {
            animEco[0].SetActive(true);
            animEco[1].SetActive(true);
            avatar[1].SetActive(false);
            avatar[2].SetActive(false);
        }
        
        //codi per activar o no el pop-up inicial
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

    //funcio per desactivar el pop-up inicial
    public void welcomeState()
    {
        welcome.SetActive(false);
        welcomeActive = false;
    }

    //funcio per activar el pop-up dels tests
    public void test1State()
    {
        test1.SetActive(true);
    }
}
