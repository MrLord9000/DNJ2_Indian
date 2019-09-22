using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotSounds : MonoBehaviour
{
    public AudioSource audioSource;
    public ThePot thePot;

    private void Update()
    {
        if(thePot.slot1 != null || thePot.slot2 != null)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Pause();
        }
    }
}
