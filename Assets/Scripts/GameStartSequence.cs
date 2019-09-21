﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GameStartSequence : MonoBehaviour
{
    private ColorGrading colorGrading;

    void Start()
    {
        colorGrading = GameManager.Instance.GetComponent<PostProcessVolume>().profile.GetSetting<ColorGrading>();
        GameManager.Player.GetComponent<PlayerController>().hasControl = false;
        StartCoroutine(Intro());
    }

    private IEnumerator Intro()
    {
        for (int i = 0; i < 128; i++)
        {
            yield return new WaitForSeconds(1f);
        }
    }
}
