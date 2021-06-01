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
    bool error = false;
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
        if (selectOneOptionScript.selected == true) {
            for (var i = 0; i < resultats.Length; i++)
            {
                if (resultats[i].tag == "sliderResultat")
                {
                    resultatsFinals[i] = resultats[i].GetComponent<Slider>().value.ToString();
                    print((i + 1) + "->" + resultatsFinals[i]);
                }
                else if (resultats[i].tag == "butonsResultat")
                {
                    if (resultats[i].GetComponentInChildren<Text>())
                    {
                        resultatsFinals[i] = resultats[i].GetComponentInChildren<Text>().text;
                        print((i + 1) + "->" + resultatsFinals[i]);
                    }
                    else
                    {
                        error = true;
                        Debug.LogWarning("No s'ha seleccionat cap boto de la pregunta " + (i + 1));
                    }
                }
                else if (resultats[i].tag == "emoticonsResultat")
                {
                        foreach (Transform child in resultats[i].GetComponentsInChildren<Transform>())
                        {
                            if (child.name!="emoticonsSelected")
                            {
                                resultatsFinals[i] = child.name;
                                print((i + 1) + "->" + resultatsFinals[i]);
                            }
                        }
                        if (resultatsFinals[i]==null)
                        {
                            error = true;
                            Debug.LogWarning("No s'ha seleccionat cap boto de la pregunta " + (i + 1));
                        }

                }

            }
            if (!error)
            {
                respostesTotals = resultatsFinals;
            }
        
        }
    }
}
