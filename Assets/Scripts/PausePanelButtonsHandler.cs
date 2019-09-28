using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanelButtonsHandler : MonoBehaviour
{
    public void Resume(GameObject pausePanel){
    	Time.timeScale=1f;
    	Destroy(pausePanel);
    }

    public void MainMenu(GameObject pausePanel){
        SceneManager.LoadScene(0);
    }
    public void Exit(GameObject pausePanel)
    {
        Application.Quit();
    }
}
