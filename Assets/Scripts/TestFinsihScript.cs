using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFinsihScript : MonoBehaviour
{
    public string lastPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changePanel()
    {
        TabScript.tabActualActive(lastPanel);
    }
}
