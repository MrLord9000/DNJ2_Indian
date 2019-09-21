﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Potion : MonoBehaviour
{
    SpriteRenderer sp;
    [SerializeField] PotionColor color;
    [SerializeField] PotionEffect action;

    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        sp.color = color.GetColor();
    }

    public void Set( Flower ingridient1, Flower ingridient2 )
    {
        color = PotionColorExtension.MixColor(ingridient1.Color, ingridient2.Color);
    }

    public PotionEffect Action
    {
        get => action;
        private set => action = value;
    }


    public static new Dictionary<PotionColor, PotionEffect> effectMap = new Dictionary<PotionColor, PotionEffect>()
    {
        { PotionColor.red,      PotionEffect.speed },
        { PotionColor.yellow,   PotionEffect.slow },
        { PotionColor.blue,     PotionEffect.large },
        { PotionColor.black,    PotionEffect.small },
        { PotionColor.white,    PotionEffect.multiplication },
        { PotionColor.maroon,   PotionEffect.halucination },
        { PotionColor.brown,    PotionEffect.invis },
        { PotionColor.cream,    PotionEffect.confusion },
        { PotionColor.navy,     PotionEffect.twist },
        { PotionColor.aqua,     PotionEffect.drunk },
        { PotionColor.gray,     PotionEffect.blackNWhite },
        { PotionColor.pink,     PotionEffect.rain },
        { PotionColor.orange,   PotionEffect.strength },
        { PotionColor.purple,   PotionEffect.levitation },
        { PotionColor.green,    PotionEffect.poison }
    };
}



