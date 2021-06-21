using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpScript : MonoBehaviour
{
    //panel del ProfilePopUp
    public GameObject popUpPanel;
    //input on surt l'opció actual triada
    public InputField actualInputValue;
    //gameObject del compopnent del po-up per escollir la nova opció
    public GameObject changeInputValue;
    //input on surt la contrassenya actual
    public InputField actualInputPassword;
    //input on s'escriu la contrassenya per comprovar que sigui la correcte
    public InputField changeInputPassword;
    //component actiu dins del panel ProfilePopUp
    public GameObject actualChangeValue;

    // Start is called before the first frame update
    void Start()
    {
        //codi per inicialitzar els inputs del pop-up
        if (changeInputValue.tag != "chageValueArray")
        {
            if (changeInputValue.GetComponentInParent<InputField>())
            {
                changeInputValue.GetComponentInParent<InputField>().text = actualInputValue.text;
            }
            else
            {
                changeInputValue.GetComponentInParent<Text>().text = actualInputValue.text;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //funció quan cliques el botó Canviar del pop-up
    public void canviarValor()
    {
        //condició per si el pop-up necessita la contrassenya
        if (PopUpProfileScript.contrassenyaActive)
        {
            //codi per canviar el valor del input dins del sub-panel Configuració dins del Perfil i desactivar el pop-up
            if (actualInputPassword.text == changeInputPassword.text)
            {
                if (changeInputValue.tag == "chageValueArray")
                {
                    var arr1 = changeInputValue.GetComponentsInChildren<RawImage>();
                    for (var i = 0; i < arr1.Length; i++)
                    {
                        if (arr1[i].tag == "fonsSelected")
                        {
                            actualInputValue.text = arr1[i].GetComponentInChildren<Text>().text;
                        }
                    }
                    popUpPanel.SetActive(false);
                    actualChangeValue.SetActive(false);
                }
                else
                {
                    actualInputValue.text = changeInputValue.GetComponent<Text>().text;
                    if (changeInputValue.GetComponent<Text>().text != "")
                    {
                        popUpPanel.SetActive(false);
                        changeInputPassword.text = "";
                        actualChangeValue.SetActive(false);
                    }
                    else
                    {
                        Debug.Log("Selecciona la nova opcio");
                    }
                }

                
            }
            else
            {
                Debug.LogWarning("El password no és el correcte");
            }
        }
        //condició per si el pop-up no necessita la contrassenya
        else
        {
            //codi per canviar el valor del input dins del sub-panel Configuració dins del Perfil i desactivar el pop-up
            if (changeInputValue.tag == "chageValueArray")
            {
                var arr1 = changeInputValue.GetComponentsInChildren<RawImage>();
                for (var i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i].tag == "fonsSelected")
                    {
                        actualInputValue.text = arr1[i].GetComponentInChildren<Text>().text;
                    }
                }
                popUpPanel.SetActive(false);
                actualChangeValue.SetActive(false);
            }
            else
            {
                actualInputValue.text = changeInputValue.GetComponent<Text>().text;

                if (actualInputValue.text != "")
                {
                    popUpPanel.SetActive(false);
                    actualChangeValue.SetActive(false);
                }
                else
                {
                    Debug.Log("Selecciona la nova opcio");
                }
            }
        }
        
        
    }

    //funció quan cliques el botó Cancel.lar del pop-up
    public void exit()
    {
        popUpPanel.SetActive(false);
        changeInputPassword.text = "";
        actualChangeValue.SetActive(false);
    }
}
