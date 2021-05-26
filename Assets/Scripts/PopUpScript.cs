using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpScript : MonoBehaviour
{
    public GameObject popUpPanel;
    public InputField actualInputValue;
    public GameObject changeInputValue;
    public InputField actualInputPassword;
    public InputField changeInputPassword;
    public GameObject actualChangeValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void canviarValor()
    {
        //canviar valor del imput
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
            }
            else{
                actualInputValue.text = changeInputValue.GetComponent<Text>().text;
            }

            if (actualInputValue.text != "")
            {
                popUpPanel.SetActive(false);
                changeInputPassword.text = "";
                if (changeInputValue.tag != "chageValueArray")
                {
                    changeInputValue.GetComponent<Text>().text = "";
                }
                actualChangeValue.SetActive(false);
            }
            else
            {
                print("Selecciona la nova opcio");
            }
        }
        else
        {
            print("p1:" + actualInputPassword.text);
            print("p2:" + changeInputPassword.text);
            print("el password no es el mateix");
        }
        
    }

    public void exit()
    {
        popUpPanel.SetActive(false);
        changeInputPassword.text = "";
        if (changeInputValue.tag != "chageValueArray")
        {
            changeInputValue.GetComponent<Text>().text = "";
        }
        actualChangeValue.SetActive(false);
    }
}
