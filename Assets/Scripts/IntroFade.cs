using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroFade : MonoBehaviour
{
    public SpriteRenderer black;
    public SpriteRenderer screen1;
    public SpriteRenderer screen2;
    public SpriteRenderer screen3;
    public SpriteRenderer screen4;

    void Start()
    {
        StartCoroutine(Intro());
    }

    private IEnumerator Intro()
    {
        for (int i = 0; i < 100; i++)
        {
            Color screenColor = black.color;
            screenColor.a = Mathf.Lerp(1, 0, (float)i / 100f);
            black.color = screenColor;
            yield return new WaitForSeconds(.05f);
        }
        for (int i = 0; i < 100; i++)
        {
            Color screenColor = screen1.color;
            screenColor.a = Mathf.Lerp(1, 0, (float)i / 100f);
            screen1.color = screenColor;
            yield return new WaitForSeconds(.05f);
        }
        for (int i = 0; i < 100; i++)
        {
            Color screenColor = screen2.color;
            screenColor.a = Mathf.Lerp(1, 0, (float)i / 100f);
            screen2.color = screenColor;
            yield return new WaitForSeconds(.05f);
        }
        for (int i = 0; i < 100; i++)
        {
            Color screenColor = screen3.color;
            screenColor.a = Mathf.Lerp(1, 0, (float)i / 100f);
            screen3.color = screenColor;
            yield return new WaitForSeconds(.05f);
        }
        for (int i = 0; i < 100; i++)
        {
            Color screenColor = screen4.color;
            screenColor.a = Mathf.Lerp(1, 0, (float)i / 100f);
            screen4.color = screenColor;
            yield return new WaitForSeconds(.05f);
        }
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Update()
    {
        if(Input.anyKey)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
