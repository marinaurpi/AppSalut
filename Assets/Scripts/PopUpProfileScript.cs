using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpProfileScript : MonoBehaviour
{
    public GameObject popup;
    public GameObject[] panelsChangeValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeValue()
    {
        popup.SetActive(true);
        for (var i = 0; i < panelsChangeValue.Length; i++)
        {
            if (panelsChangeValue[i].name == this.name)
            {
                print(this.name);
                panelsChangeValue[i].SetActive(true);
            }
        }
    }
}
