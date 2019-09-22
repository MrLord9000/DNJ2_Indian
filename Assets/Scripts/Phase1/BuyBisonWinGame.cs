using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class BuyBisonWinGame : MonoBehaviour
{
    public GameObject bisonPrefab;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if( collision.tag == "Bison" && GameManager.Inventory.bank >= 100)
        {
            StartCoroutine(FadeOutWin());
        }
    }

    private IEnumerator FadeOutWin()
    {
        GameManager.Player.GetComponent<PlayerController>().hasControl = false;
        ColorGrading colorGrading = GameManager.Instance.GetComponent<PostProcessVolume>().profile.GetSetting<ColorGrading>();
        for (int i = 0; i >= -100; i--)
        {
            colorGrading.brightness.value = i;
            yield return new WaitForSeconds(.1f);
        }
        SceneManager.LoadScene(4);
    }
}
