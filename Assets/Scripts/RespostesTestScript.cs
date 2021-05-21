using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;

public class RespostesTestScript : MonoBehaviour
{
    public GameObject[] resultats;
    string[] resultatsFinals = new string[13];
    static public string[] respostesTotals;
    Slider test;
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResultatsFinals()
    {
        for (var i = 0; i < resultats.Length; i++)
        {
            if (resultats[i].tag == "sliderResultat")
            {
                resultatsFinals[i] = resultats[i].GetComponent<Slider>().value.ToString();
                print(i+"->" + resultatsFinals[i]);
            }
            else if (resultats[i].tag == "butonsResultat")
            {
                resultatsFinals[i] = resultats[i].GetComponentInChildren<Text>().text;
                print(i + "->" + resultatsFinals[i]);
            }
            else if (resultats[i].tag == "emoticonsResultat")
            {
                foreach (Transform child in resultats[i].GetComponentsInChildren<Transform>())
                {
                    resultatsFinals[i] = child.name;
                }
                print(i + "->" + resultatsFinals[i]);
            }
        }
        respostesTotals = resultatsFinals;
    }
}
