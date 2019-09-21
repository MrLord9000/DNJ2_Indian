using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
#pragma warning disable
    [SerializeField] TextMeshProUGUI displayText;
#pragma warning restore

    public delegate void PhaseOneEndAction();
    public static event PhaseOneEndAction OnPhaseEnd;

    public void StartTimer()
    {
        StartCoroutine(Timer(GameManager.Instance.basePlayTime));
    }

    public IEnumerator Timer(int lengthInSeconds)
    {
        int timeLeft = lengthInSeconds;
        for (int i = 0; i < lengthInSeconds; i++)
        {
            DrawTime(timeLeft);
            timeLeft--;
            yield return new WaitForSeconds(1f);
        }
        OnPhaseEnd?.Invoke();
    }

    private void DrawTime(int time)
    {
        if (displayText != null)
        {
            displayText.text = (time/60) + ":" + (time%60);
        }
    }
}
