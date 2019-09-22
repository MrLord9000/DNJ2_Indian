﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D),typeof(SpriteRenderer))]
public class Flower : MonoBehaviour//, IInventoryItem
{

    new private BoxCollider2D collider;

    private Vector3 pos;
    private SpriteRenderer sRenderer;

    [SerializeField] FlowerColor color;

    public FlowerColor Color
    {
        get => color;
        set
        {
            color = value;
            {
                string path1 = "Sprites/Flowers/flower_" + color + "_1";
                string path2 = "Sprites/Flowers/flower_" + color + "_2";
                Sprite pic = Resources.Load<Sprite>(Random.Range(0, 2) == 1 ? path1 : path2) ?? Resources.Load<Sprite>(path1);
                sRenderer.sprite = pic;
                collider.size = new Vector3(pic.textureRect.width, pic.textureRect.height) / pic.pixelsPerUnit * 1.5f;
            }
        }
    }

    public void Highlight()
    {
        sRenderer.material.SetFloat("_OutlineWidth", 1f);
    }

    public void Unhighlight()
    {
        sRenderer.material.SetFloat("_OutlineWidth", 0f);
    }

    public string Name
    {
        get => Color.ToString() + " flower";
    }

    public Sprite Image
    {
        get => sRenderer.sprite;
        set => sRenderer.sprite = value;
    }
    /*
    void OnValidate()
    {
        collider = GetComponent<BoxCollider2D>();
        sRenderer = GetComponent<SpriteRenderer>();
        //TYMCZASOWE
        //GetComponent<SpriteRenderer>().color = color.GetColor();
        //Color = color;

    }*/

    void Awake()
    {
        collider = GetComponent<BoxCollider2D>();
        sRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        List<Collider2D> results = new List<Collider2D>();
        collider.OverlapCollider( new ContactFilter2D().NoFilter(),results);
        foreach(Collider2D result in results){
            if(result.gameObject.GetComponent<PlayerController>()==null){
                Destroy(result.gameObject);
            }
        }
    }


    public void OnPickup()
    {
        gameObject.SetActive(false);
    }

}

public enum FlowerColor
{
    //basics
    red,
    yellow,
    blue,
    black,
    white,
    //special
    pink,
    orange,
    purple,
    green
}

public static class FlowerColorExtension
{
    public static Color GetColor(this FlowerColor fc)
    {
        string code = "";
        switch (fc)
        {
            case FlowerColor.red:
                code = "#b70e0e";
                break;
            case FlowerColor.yellow:
                code = "#eacc08";
                break;
            case FlowerColor.blue:
                code = "#1a2d8c";
                break;
            case FlowerColor.black:
                code = "#170801";
                break;
            case FlowerColor.white:
                code = "#f3fafa";
                break;

            case FlowerColor.pink:
                code = "#ffb6b6";
                break;
            case FlowerColor.orange:
                code = "#ff6c03";
                break;
            case FlowerColor.purple:
                code = "#551764";
                break;
            case FlowerColor.green:
                code = "#13881b";
                break;
        }
        ColorUtility.TryParseHtmlString(code, out Color color);
        return color;
    }

    public static PotionColor GetPotionColor( this FlowerColor fc)
    {
        switch (fc)
        {
            case FlowerColor.red:       return PotionColor.red;
            case FlowerColor.yellow:    return PotionColor.yellow;
            case FlowerColor.blue:      return PotionColor.blue;
            case FlowerColor.black:     return PotionColor.black; 
            case FlowerColor.white:     return PotionColor.white; 
            case FlowerColor.pink:      return PotionColor.pink; 
            case FlowerColor.orange:    return PotionColor.orange;
            case FlowerColor.purple:    return PotionColor.purple;
            case FlowerColor.green:     return PotionColor.green;
            default:                    return PotionColor.white;
        }
    }

    public static bool IsBasic(this FlowerColor fc)
    {
        switch (fc)
        {
            case FlowerColor.red:
            case FlowerColor.yellow:
            case FlowerColor.blue:
            case FlowerColor.black:
            case FlowerColor.white:
                return true;

            default:
                return false;
        }
    }
}