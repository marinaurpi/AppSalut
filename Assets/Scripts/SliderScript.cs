using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public Slider sliderObject;
    public GameObject cercle;
    public Sprite emotiAngry, emotiHappy;

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
        print(sliderObject.value);
        if (sliderObject.value >= 0 && sliderObject.value <= 0.5)
        {
            cercle2.sprite = emotiAngry;
        }
        else
        {
            cercle2.sprite = emotiHappy;
        }
    }
}
