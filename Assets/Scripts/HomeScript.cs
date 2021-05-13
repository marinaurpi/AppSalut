using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScript : MonoBehaviour
{
    public GameObject welcome, test1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void welcomeState()
    {
        welcome.SetActive(false);
    }

    public void test1State()
    {
        test1.SetActive(true);
    }
}
