using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UserOptionManager : MonoBehaviour
{
    public GameObject[] backgroundOptions, avatarOptions;
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
        for (var i = 0; i < backgroundOptions.Length; i++)
        {
            if (backgroundOptions[i].active == true)
            {
                fons = i;
            }
        }
        for (var j = 0; j < avatarOptions.Length; j++)
        {
            if (avatarOptions[j].active == true)
            {
                avatar = j;
            }
        }
    }
}
