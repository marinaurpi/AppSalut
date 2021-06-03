using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class avatarFonsScript : MonoBehaviour
{
    public GameObject[] avatar;
    public GameObject[] fons;
    public Texture[] fonsTexture;
    public Texture[] avatarTexture;

    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < fons.Length; i++)
        {
            fons[i].GetComponent<RawImage>().texture = fonsTexture[UserOptionManager.fons];
        }
        for (var j = 0; j < avatar.Length; j++)
        {
            avatar[j].GetComponent<RawImage>().texture = avatarTexture[UserOptionManager.avatar];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
