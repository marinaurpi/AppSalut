using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UserOptionManager : MonoBehaviour
{
    public RectTransform background, reptes, avatar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goReptes()
    {
        reptes.DOAnchorPos(Vector2.zero, 0.25f);
        background.DOAnchorPos(new Vector2(-6575, 0), 0.25f);
    }

    public void goAvatar()
    {
        avatar.DOAnchorPos(Vector2.zero, 0.25f);
        reptes.DOAnchorPos(new Vector2(-6575, 0), 0.25f);
    }

    public void backBackground()
    {
        background.DOAnchorPos(Vector2.zero, 0.25f);
        reptes.DOAnchorPos(new Vector2(6575, 0), 0.25f);
    }

    public void backReptes()
    {
        reptes.DOAnchorPos(Vector2.zero, 0.25f);
        avatar.DOAnchorPos(new Vector2(6575, 0), 0.25f);
    }
}
