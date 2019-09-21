using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToPhase2 : MonoBehaviour
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
        SceneManager.LoadScene(2);
    }
}
