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
            colorGrading.brightness.value = Mathf.Lerp(-50, 0, (float)timeLeft / (float)lengthInSeconds);
            colorGrading.temperature.value = Mathf.Lerp(-20, 0, (float)timeLeft / (float)lengthInSeconds);
            DrawTime(timeLeft);
            timeLeft--;
            yield return new WaitForSeconds(1f);
        }
        GameManager.Player.GetComponent<PlayerController>().hasControl = false;
        for (int i = 0; i < 50; i++)
        {
            colorGrading.brightness.value -= 1f;
            yield return new WaitForSeconds(.1f);
        }
        yield return new WaitForSeconds(2f);
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
