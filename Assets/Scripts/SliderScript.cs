using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider sliderObject;
    public GameObject cercle;
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
        }
        else if(sliderObject.value > 0.2 && sliderObject.value <= 0.4)
        {
            cercle2.sprite = emotiAngry2;
        }
        else if (sliderObject.value > 0.4 && sliderObject.value <= 0.6)
        {
            cercle2.sprite = emotyNormal;
        }
        else if (sliderObject.value > 0.6 && sliderObject.value <= 0.8)
        {
            cercle2.sprite = emotiHappy;
        }
        else if (sliderObject.value > 0.8 && sliderObject.value <= 1)
        {
            cercle2.sprite = emotiHappy2;
        }
    }
}
