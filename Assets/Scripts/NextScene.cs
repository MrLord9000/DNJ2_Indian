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
        Inventory inventoty = FindObjectOfType<Inventory>();
        foreach( Flower flower in inventoty.flowerItems )
        {
            inventoty.flowers[flower.Color]++;
        }
        foreach (Potion potion in inventoty.potionItems)
        {
            DontDestroyOnLoad(potion);
        }
        foreach( var elem in inventoty.flowers)
        {
            Debug.Log(elem.Key + ": " + elem.Value);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
