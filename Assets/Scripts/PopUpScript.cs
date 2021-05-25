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
            actualInputValue.text = changeInputValue.GetComponent<Text>().text;

        }
        else
        {
            print("p1:" + actualInputPassword.text);
            print("p2:" + changeInputPassword.text);
            print("el password no es el mateix");
        }
        popUpPanel.SetActive(false);

        changeInputPassword.text = "";
        changeInputValue.GetComponent<Text>().text = "";
        actualChangeValue.SetActive(false);
    }

    public void exit()
    {
        popUpPanel.SetActive(false);

        changeInputPassword.text = "";
        changeInputValue.GetComponent<Text>().text = "";
        actualChangeValue.SetActive(false);
    }
}
