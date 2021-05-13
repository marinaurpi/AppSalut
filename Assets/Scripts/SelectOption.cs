using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectOption : MonoBehaviour
{
    public GameObject select;
    bool selected = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectButton()
    {
        if (selected)
        {
            select.SetActive(true);
            selected = false;
        }
        else
        {
            select.SetActive(false);
            selected = true;
        }
    }
}
