﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightMeter : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer img;

    public Sprite meter0;
    public Sprite meter1;
    public Sprite meter2;
    public Sprite meter3;
    public Sprite meter4;
    public Sprite meter5;
    public Sprite meter6;
    public Sprite meter7;

    Sprite[] meter;

    GameObject player;

    private int illumination;

    void Start()
    {
        img = this.gameObject.GetComponent<SpriteRenderer>();
        player = GameObject.Find("Player");
        meter = new Sprite[] { meter0, meter1, meter2, meter3, meter4, meter5, meter6, meter7 };
    }

    // Update is called once per frame
    void Update() 
    {
        illumination = player.GetComponent<CharacterController2D>().illuminationCounter / 10;
        img.sprite = meter[illumination];
    }

    public int getIllumination()
    {
        return illumination;
    }
}