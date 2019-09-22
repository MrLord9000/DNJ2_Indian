using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
	public GameObject pausePanel;
    public Canvas gameUI;

    public void PauseTheGame(GameObject panel){
        
    	if(Time.timeScale > 0f)
        {
            pausePanel = Instantiate(panel, gameUI.transform);
    		pausePanel.SetActive(true);
    		Time.timeScale = 0f;
    	}
    	//else{
    	//	pausePanel.SetActive(false);
    	//	Destroy(pausePanel);
    	//	Time.timeScale=1f;
    	//}
    }
}
