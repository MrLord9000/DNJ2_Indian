using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
	public GameObject curtain;

    public void StartGame(){
    	StartCoroutine(Fade(3f));
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void QuitGame(){
    	StartCoroutine(Fade(3f));
    	Application.Quit();
    }

    private IEnumerator Fade(float fadeOutTime)
     {
         float t = 0.0f;
         while (t<1.0f)
         {
             
             t = Mathf.Clamp01(t + Time.deltaTime / fadeOutTime);
             curtain.GetComponent<Image>().color = new Color(curtain.GetComponent<Image>().color.r,curtain.GetComponent<Image>().color.g,curtain.GetComponent<Image>().color.b,t);
             yield return new WaitForEndOfFrame();
         }
     }
}
