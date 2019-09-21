using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionIcon : MonoBehaviour
{
    [SerializeField] SpriteRenderer iconRenderer;
    
    public void Activate( PotionColor color )
    {
        PotionEffect effect = Potion.effectMap[color];

        string path = "Sprites/interface/effect_" + effect;

        Sprite icon = Resources.Load<Sprite>(path);

        iconRenderer.sprite = icon;
        iconRenderer.color = color.GetColor();

        iconRenderer.enabled = true;
    }

    public void Deactivate()
    {
        iconRenderer.enabled = false;
    }
}
