using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFonsAvatarValueScript : MonoBehaviour
{
    public GameObject[] butons;
    public GameObject buton;
    public GameObject[] selectImages;
    public GameObject selectImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void butonSelected()
    {
        for (var i = 0; i < butons.Length; i++)
        {
            butons[i].tag = "fonsNoSelected";
            selectImages[i].SetActive(false);

        }
        buton.tag = "fonsSelected";
        selectImage.SetActive(true);
    }
}
