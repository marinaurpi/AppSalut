using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoticonsScript : MonoBehaviour
{
    public GameObject[] emotiocons;
    public GameObject selected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectEmoti()
    {
        for (var i = 0; i < emotiocons.Length; i++)
        {
            if (emotiocons[i].active == true)
            {
                emotiocons[i].SetActive(false);
            }
        }
        selected.SetActive(true);
    }
}
