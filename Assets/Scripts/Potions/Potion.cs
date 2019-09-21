﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[RequireComponent(typeof(SpriteRenderer))]
public class Potion : MonoBehaviour//, IInventoryItem
{
    SpriteRenderer sRenderer;
    [SerializeField] PotionColor color;
    [SerializeField] PotionEffect action;
    public static float duration = 20;

    // Start is called before the first frame update
    void Awake()
    {
        sRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //sRenderer.color = color.GetColor();
    }

    public void Set( Flower ingridient1, Flower ingridient2 )
    {
        Color = PotionColorExtension.MixColor(ingridient1.Color, ingridient2.Color);
        action = effectMap[color];
    }
    public void Set(PotionColor pc)
    {
        Color = pc;
        action = effectMap[color];
    }

    public void Use()
    {
        Debug.Log(action + " potion");
        switch (action)
        {
            case PotionEffect.speed:            GameManager.Instance.StartCoroutine(SpeedPotionEffect());            break;
            case PotionEffect.slow:             GameManager.Instance.StartCoroutine(SlowPotionEffect());             break;
            case PotionEffect.large:            GameManager.Instance.StartCoroutine(LargePotionEffect());            break;
            case PotionEffect.small:            GameManager.Instance.StartCoroutine(SmallPotionEffect());            break;
            case PotionEffect.multiplication:   GameManager.Instance.StartCoroutine(MultiplicationPotionEffect());   break;
            case PotionEffect.halucination:     GameManager.Instance.StartCoroutine(HalucinationPotionEffect());     break;
            case PotionEffect.invis:            GameManager.Instance.StartCoroutine(InvisPotionEffect());            break;
            case PotionEffect.confusion:        GameManager.Instance.StartCoroutine(ConfusionPotionEffect());        break;
            case PotionEffect.twist:            GameManager.Instance.StartCoroutine(TwistPotionEffect());            break;
            case PotionEffect.drunk:            GameManager.Instance.StartCoroutine(DrunkPotionEffect());            break;
            case PotionEffect.blackNWhite:      GameManager.Instance.StartCoroutine(BlackNWhitePotionEffect());      break;
            case PotionEffect.rain:             GameManager.Instance.StartCoroutine(RainPotionEffect());             break;
            case PotionEffect.strength:         GameManager.Instance.StartCoroutine(StrengthPotionEffect());         break;
            case PotionEffect.levitation:       GameManager.Instance.StartCoroutine(LevitationPotionEffect());       break;
            case PotionEffect.poison:           GameManager.Instance.StartCoroutine(PoisonPotionEffect());           break;
        }
    }

    public PotionEffect Action
    {
        get => action;
        private set => action = value;
    }
    public PotionColor Color
    {
        get => color;
        private set
        {
            color = value;
            sRenderer.color = color.GetColor();
        }
    }
    
    public string Name
    {
        get => color.ToString() + " flower";
    }

    public Sprite Image
    {
        get => sRenderer.sprite;
        set => sRenderer.sprite = value;
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
    
    public IEnumerator SpeedPotionEffect()
    {
        GameManager.Player.GetComponent<PlayerController>().speed *= 1.5f;
        yield return new WaitForSeconds(duration);
        GameManager.Player.GetComponent<PlayerController>().speed /= 1.5f;
    }
    public IEnumerator SlowPotionEffect()
    {
        GameManager.Player.GetComponent<PlayerController>().speed *= 0.5f;
        yield return new WaitForSeconds(duration);
        GameManager.Player.GetComponent<PlayerController>().speed /= 0.5f;
    }
    public IEnumerator LargePotionEffect()
    {
        GameManager.Player.transform.localScale *= 1.5f;
        yield return new WaitForSeconds(duration);
        GameManager.Player.transform.localScale /= 1.5f;
    }
    public IEnumerator SmallPotionEffect()
    {
        GameManager.Player.transform.localScale *= 0.5f;
        yield return new WaitForSeconds(duration);
        GameManager.Player.transform.localScale /= 0.5f;
    }

    static float range = 0.5f;
    public IEnumerator MultiplicationPotionEffect()
    {
        float time = 0;
        float next;
        List<GameObject> phantoms = new List<GameObject>();

        while (time + (next = Random.Range(1f, 5f)) < duration)
        {
            foreach( GameObject obj in phantoms )
            {
                GameManager.Destroy(obj);
            }
            phantoms.Clear();

            int   n = Random.Range(2, 6);

            for( int i=0; i<n; i++ )
            {
                float x = Random.Range(-1f, 1f);
                float y = Random.Range(-1f, 1f);
                float distance = Random.Range(0, range);
                GameObject phantom = GameManager.Instantiate(GameManager.Player, new Vector2(x,y).normalized * distance, new Quaternion() );
                x = Random.Range(-1f, 1f);
                y = Random.Range(-1f, 1f);
                phantom.GetComponent<PlayerController>().enabled = false;
                phantom.GetComponent<UnityEngine.InputSystem.PlayerInput>().enabled = false;
                phantoms.Add(phantom);
            }

            time += next;
            yield return new WaitForSeconds(next);
        }

        foreach (GameObject obj in phantoms)
        {
            GameManager.Destroy(obj);
        }
        phantoms.Clear();
    }
    public IEnumerator HalucinationPotionEffect()
    {
        ColorGrading colorGrading = GameManager.Instance.GetComponent<PostProcessVolume>().profile.GetSetting<ColorGrading>();
        for (int i = 0; i < 720; i++)
        {
            if(colorGrading.hueShift.value < 180)
            {
                colorGrading.hueShift.value += 1f;
            }
            else
            {
                colorGrading.hueShift.value = -180f;
            }
            yield return new WaitForSeconds(.02f);
        }
        colorGrading.hueShift.value = 0;
    }
    public IEnumerator InvisPotionEffect()
    {
        GameManager.Player.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(duration);
        GameManager.Player.GetComponent<SpriteRenderer>().enabled = true;
    }
    public IEnumerator ConfusionPotionEffect()
    {
        //FX
        throw new System.NotImplementedException();
    }
    public IEnumerator TwistPotionEffect()
    {
        Camera.main.transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
        yield return new WaitForSeconds(duration);
        Camera.main.transform.rotation = new Quaternion();
    }

    static float force = 15;
    public IEnumerator DrunkPotionEffect()
    {
        float time = 0;
        float next;
        while ( time + ( next = Random.Range(1f,5f) ) < duration)
        {
            float x = Random.Range(-1f, 1f);
            float y = Random.Range(-1f, 1f);
            GameManager.Player.GetComponent<Rigidbody2D>().AddForce( new Vector2(x,y).normalized * force,  ForceMode2D.Impulse);
            time += next;
            yield return new WaitForSeconds(next);
        }
    }
    public IEnumerator BlackNWhitePotionEffect()
    {
        //FX
        throw new System.NotImplementedException();
    }
    public IEnumerator RainPotionEffect()
    {
        //FX
        throw new System.NotImplementedException();
    }
    public IEnumerator StrengthPotionEffect()
    {
        //inventory
        throw new System.NotImplementedException();
    }
    public IEnumerator LevitationPotionEffect()
    {
        GameManager.Player.GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(duration);
        GameManager.Player.GetComponent<Collider2D>().enabled = true;
    }
    public IEnumerator PoisonPotionEffect()
    {
        //zmiana sceny
        throw new System.NotImplementedException();
    }
}



