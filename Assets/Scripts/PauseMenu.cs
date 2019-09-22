using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
	static GameObject pausePanel;


    public static void PauseTheGame(GameObject panel){
    	if(Time.timeScale>0f){
    		pausePanel=Instantiate(panel);
    		pausePanel.SetActive(true);
    		Time.timeScale = 0f;
    	}
    	else{
    		pausePanel.SetActive(false);
    		Destroy(pausePanel);
    		Time.timeScale=1f;
    	}
    }
}
