using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider sliderObject;
    public GameObject cercle;
    public GameObject barra;
    public Sprite[] barresColors;
    public Sprite emotiAngry, emotiAngry2, emotyNormal, emotiHappy, emotiHappy2;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ValueChange()
    {
        var cercle2 = cercle.GetComponent<Image>();
        if (sliderObject.value >= 0 && sliderObject.value <= 0.2)
        {
            cercle2.sprite = emotiAngry;
            barra.GetComponent<Image>().sprite = barresColors[0];
        }
        else if(sliderObject.value > 0.2 && sliderObject.value <= 0.4)
        {
            cercle2.sprite = emotiAngry2;
            barra.GetComponent<Image>().sprite = barresColors[1];
        }
        else if (sliderObject.value > 0.4 && sliderObject.value <= 0.6)
        {
            cercle2.sprite = emotyNormal;
            barra.GetComponent<Image>().sprite = barresColors[2];
        }
        else if (sliderObject.value > 0.6 && sliderObject.value <= 0.8)
        {
            cercle2.sprite = emotiHappy;
            barra.GetComponent<Image>().sprite = barresColors[3];
        }
        else if (sliderObject.value > 0.8 && sliderObject.value <= 1)
        {
            cercle2.sprite = emotiHappy2;
            barra.GetComponent<Image>().sprite = barresColors[4];
        }
    }
}
