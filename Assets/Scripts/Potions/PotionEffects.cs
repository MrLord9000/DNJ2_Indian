using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PotionEffects
{
    public static float duration = 20;

    public static void Invoke( PotionEffect effect )
    {
        switch( effect )
        {
            case PotionEffect.speed:            GameManager.Instance.StartCoroutine( SpeedPotionEffect() ); break;
            case PotionEffect.slow:             GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;
            case PotionEffect.large:            GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;
            case PotionEffect.small:            GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;
            case PotionEffect.multiplication:   GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;
            case PotionEffect.halucination:     GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;
            case PotionEffect.invis:            GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;
            case PotionEffect.confusion:        GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;
            case PotionEffect.twist:            GameManager.Instance.StartCoroutine( SpeedPotionEffect() ); break;
            case PotionEffect.blackNWhite:      GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;
            case PotionEffect.rain:             GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;
            case PotionEffect.strength:         GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;
            case PotionEffect.levitation:       GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;
            case PotionEffect.poison:           GameManager.Instance.StartCoroutine(SpeedPotionEffect()); break;

        }
        
    }

    public static IEnumerator SpeedPotionEffect()
    {
        GameManager.Player.GetComponent<PlayerController>().speed *= 1.5f;
        yield return new WaitForSeconds(duration);
        GameManager.Player.GetComponent<PlayerController>().speed /= 1.5f;
    }
    public static IEnumerator SlowPotionEffect()
    {
        GameManager.Player.GetComponent<PlayerController>().speed = 0.5f;
        yield return new WaitForSeconds(duration);
        GameManager.Player.GetComponent<PlayerController>().speed = 1f;
    }
    public static IEnumerator LargePotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator SmallPotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator MultiplicationPotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator HalucinationPotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator InvisPotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator ConfusionPotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator TwistPotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator DrunkPotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator BlackNWhitePotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator RainPotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator StrengthPotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator LevitationPotionEffect()
    {
        throw new System.NotImplementedException();
    }
    public static IEnumerator PoisonPotionEffect()
    {
        throw new System.NotImplementedException();
    }
}
