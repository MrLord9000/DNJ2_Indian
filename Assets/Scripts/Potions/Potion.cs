using System.Collections;
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
        { PotionColor.red,      PotionEffect.Speed },
        { PotionColor.yellow,   PotionEffect.Slow },
        { PotionColor.blue,     PotionEffect.Large },
        { PotionColor.black,    PotionEffect.Small },
        { PotionColor.white,    PotionEffect.Multiplication },
        { PotionColor.maroon,   PotionEffect.Halucination },
        { PotionColor.brown,    PotionEffect.Invis },
        { PotionColor.cream,    PotionEffect.Confusion },
        { PotionColor.navy,     PotionEffect.Twist },
        { PotionColor.aqua,     PotionEffect.Drunk },
        { PotionColor.gray,     PotionEffect.BlackNWhite },
        { PotionColor.pink,     PotionEffect.Rain },
        { PotionColor.orange,   PotionEffect.Strength },
        { PotionColor.purple,   PotionEffect.Levitation },
        { PotionColor.green,    PotionEffect.Poison }
    };
}



