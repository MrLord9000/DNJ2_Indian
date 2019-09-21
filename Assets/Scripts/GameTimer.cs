using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering.PostProcessing;

public class GameTimer : MonoBehaviour
{
#pragma warning disable
    [SerializeField] TextMeshProUGUI displayText;
#pragma warning restore

    public delegate void PhaseOneEndAction();
    public static event PhaseOneEndAction OnPhaseEnd;

    private ColorGrading colorGrading;

    private void Start()
    {
        colorGrading = GameManager.Instance.GetComponent<PostProcessVolume>().profile.GetSetting<ColorGrading>();
    }

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
            displayText.text = (time/60).ToString("00") + ":" + (time%60).ToString("00");
        }
    }
}
