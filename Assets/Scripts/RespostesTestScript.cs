using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class RespostesTestScript : MonoBehaviour
{
    public GameObject[] resultats;
    string[] resultatsFinals = new string[5];
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
                print(resultatsFinals[i]);
            }
            else if (resultats[i].tag == "butonsResultat")
            {
                resultatsFinals[i] = resultats[i].GetComponentInChildren<Text>().text;
                print(resultatsFinals[i]);
            }
        }
    }
}
