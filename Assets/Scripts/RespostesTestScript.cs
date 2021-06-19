using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.WSA;

public class RespostesTestScript : MonoBehaviour
{
    //totes les opcions de les diferents preguntes del test
    public GameObject[] resultats;
    //array on agruparem totes les respostes seleccionades en format string
    string[] resultatsFinals = new string[13];
    static public string[] respostesTotals;
    //per saber si hi ha algun error durant el proces de selecció de respostes
    bool error = false;

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
            //Analitzar totes les opcions i agrupar les opcions seleccionades dins d'un array en format string
            for (var i = 0; i < resultats.Length; i++)
            {
                //S'ha de posar el tag de sliderResultat als sliders per poder saber com tractar-los com strings
                if (resultats[i].tag == "sliderResultat")
                {
                    resultatsFinals[i] = resultats[i].GetComponent<Slider>().value.ToString();
                    Debug.Log((i + 1) + "->" + resultatsFinals[i]);
                }
                //S'ha de posar el tag de butonsResultat als botons per poder saber com tractar-los com strings
                else if (resultats[i].tag == "butonsResultat")
                {
                    if (resultats[i].GetComponentInChildren<Text>())
                    {
                        resultatsFinals[i] = resultats[i].GetComponentInChildren<Text>().text;
                        Debug.Log((i + 1) + "->" + resultatsFinals[i]);
                    }
                    else
                    {
                        error = true;
                        Debug.LogWarning("No s'ha seleccionat cap boto de la pregunta " + (i + 1));
                    }
                }
                //S'ha de posar el tag de emoticonsResultat als botons emoticons per poder saber com tractar-los com strings
                else if (resultats[i].tag == "emoticonsResultat")
                {
                        foreach (Transform child in resultats[i].GetComponentsInChildren<Transform>())
                        {
                            if (child.name!="emoticonsSelected")
                            {
                                resultatsFinals[i] = child.name;
                                Debug.Log((i + 1) + "->" + resultatsFinals[i]);
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
