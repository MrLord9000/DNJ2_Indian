using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class IntroScene : MonoBehaviour
{
    public PostProcessVolume postProcessing;
    private ColorGrading colorGrading;

    void Start()
    {
        colorGrading = postProcessing.profile.GetSetting<ColorGrading>();
        colorGrading.brightness.value = -100;
        StartCoroutine("SceneAnimation");
    }

    private IEnumerator SceneAnimation()
    {
        for (int i = -100; i <= 0; i++)
        {
            colorGrading.brightness.value = i;
            yield return new WaitForSeconds(.1f);
        }
        if (Input.anyKey)
        {
            for (int i = 0; i >= -100; i--)
            {
                colorGrading.brightness.value = i;
                yield return new WaitForSeconds(.1f);
            }
        }
    }
}
