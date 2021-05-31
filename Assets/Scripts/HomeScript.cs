using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScript : MonoBehaviour
{
    public GameObject welcome, test1;
    public static bool welcomeActive = true;
    public static string idioma = "Català"; 

    // Start is called before the first frame update
    void Start()
    {
        if (welcomeActive)
        {
            welcome.SetActive(true);
        }
        else
        {
            welcome.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void welcomeState()
    {
        welcome.SetActive(false);
        welcomeActive = false;
    }

    public void test1State()
    {
        test1.SetActive(true);
    }
}
