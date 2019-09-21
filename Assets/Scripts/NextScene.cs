using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    private void OnEnable()
    {
        GameTimer.OnPhaseEnd += NextPhase;
    }

    private void OnDisable()
    {
        GameTimer.OnPhaseEnd -= NextPhase;
    }

    private void NextPhase()
    {
        Debug.Log("Next Phase");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
