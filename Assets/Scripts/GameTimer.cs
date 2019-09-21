using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
#pragma warning disable
    [SerializeField] float maxPlayTime = 30f;
    [SerializeField] TextMeshProUGUI displayText;
#pragma warning restore

    private float timeElapsed;
    public float TimeElapsed { get => timeElapsed; }

    public delegate void PhaseOneEndAction();
    public static event PhaseOneEndAction OnPhaseEnd;

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > maxPlayTime)
        {
            OnPhaseEnd();
        }

        if (displayText != null)
        {
            displayText.text = timeElapsed.ToString();
        }
    }
}
