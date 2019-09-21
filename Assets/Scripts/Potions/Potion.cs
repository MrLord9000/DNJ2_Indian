using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Potion : MonoBehaviour//, IInventoryItem
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
        action = effectMap[color];
    }
    public void Set(PotionColor pc)
    {
        color = pc;
        action = effectMap[color];
    }

    public PotionEffect Action
    {
        get => action;
        private set => action = value;
    }
    public PotionColor Color
    {
        get => color;
        private set => color = value;
    }
    
    public string Name
    {
        get => color.ToString() + " flower";
    }

    public Sprite Image
    {
        get => sp.sprite;
        set => sp.sprite = value;
    }


    public static Dictionary<PotionColor, PotionEffect> effectMap = new Dictionary<PotionColor, PotionEffect>()
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



