using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectOneOptionScript : MonoBehaviour
{
    public GameObject[] respostes;
    public GameObject res;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void selectResposta()
    {
        for (var i = 0; i < respostes.Length; i++)
        {
            if (respostes[i].active == true)
            {
                respostes[i].SetActive(false);
            }
        }
        res.SetActive(true);
    }
}
