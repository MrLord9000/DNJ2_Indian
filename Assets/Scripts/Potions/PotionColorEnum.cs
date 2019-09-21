using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PotionColor
{
    //TIER1
    red = 0,
    yellow,
    blue,
    green,
    orange,
    purple,
    //TIER2
    pink = 6,
    maroon,
    brown,
    cream,
    navy,
    aqua,
    //TIER3
    black = 12,
    white,
    gray,


}

public static class PotionColorExtension
{
    public static Color GetColor(this PotionColor fc)
    {
        string code = "";
        switch (fc)
        {
            case PotionColor.red:
                code = "#b70e0e";
                break;
            case PotionColor.yellow:
                code = "#eacc08";
                break;
            case PotionColor.blue:
                code = "#1a2d8c";
                break;
            case PotionColor.black:
                code = "#170801";
                break;
            case PotionColor.white:
                code = "#f3fafa";
                break;

            case PotionColor.pink:
                code = "#ffb6b6";
                break;
            case PotionColor.orange:
                code = "#ff6c03";
                break;
            case PotionColor.purple:
                code = "#551764";
                break;
            case PotionColor.green:
                code = "#13881b";
                break;

            case PotionColor.maroon:
                code = "#6a0202";
                break;
            case PotionColor.brown:
                code = "#564901";
                break;
            case PotionColor.cream:
                code = "#fff198";
                break;
            case PotionColor.navy:
                code = "#010d4d";
                break;
            case PotionColor.aqua:
                code = "#9dadff";
                break;
            case PotionColor.gray:
                code = "#676767";
                break;
        }
        ColorUtility.TryParseHtmlString(code, out Color color);
        return color;
    }

    public static PotionColor MixColor(FlowerColor c1, FlowerColor c2)
    {
        if (c1 > c2)
        {
            (c1, c2) = (c2, c1);
        }

        if (c1.IsBasic() && c2.IsBasic())
        {
            if (c1 == c2)
            {
                return c1.GetPotionColor();
            }
            else if (c1 == FlowerColor.red)
            {
                if (c2 == FlowerColor.yellow) return PotionColor.orange;
                if (c2 == FlowerColor.blue) return PotionColor.purple;
                if (c2 == FlowerColor.black) return PotionColor.maroon;
                if (c2 == FlowerColor.white) return PotionColor.pink;
            }
            else if (c1 == FlowerColor.yellow)
            {
                if (c2 == FlowerColor.blue) return PotionColor.green;
                if (c2 == FlowerColor.black) return PotionColor.brown;
                if (c2 == FlowerColor.white) return PotionColor.cream;
            }
            else if (c1 == FlowerColor.blue)
            {
                if (c2 == FlowerColor.black) return PotionColor.navy;
                if (c2 == FlowerColor.white) return PotionColor.aqua;
            }
            else if (c1 == FlowerColor.white)
            {
                if (c2 == FlowerColor.black) return PotionColor.navy;
                if (c2 == FlowerColor.white) return PotionColor.aqua;
            }
        }
        else
        {
            if (Random.Range(0, 2) > 0.5f)
            {
                return c1.GetPotionColor();
            }
            else
            {
                return c2.GetPotionColor();
            }
        }

        return PotionColor.white;
    }
}