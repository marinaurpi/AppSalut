using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserOptionManager : MonoBehaviour
{
    //Totes les opcions de fons i d'avatars dins d'un array
    public GameObject[] backgroundOptions, avatarOptions;
    //Variables estatiques per saber quin fons i quin avatar estan seleccionats
    public static int fons, avatar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void opcionsSeleccionades()
    {
        //Per saber quin fons està seleccionat
        for (var i = 0; i < backgroundOptions.Length; i++)
        {
            if (backgroundOptions[i].active == true)
            {
                fons = i;
            }
        }
        //Per saber quin avatar està seleccionat
        for (var j = 0; j < avatarOptions.Length; j++)
        {
            if (avatarOptions[j].active == true)
            {
                avatar = j;
            }
        }
    }
}
