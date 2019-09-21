using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phase2LevelManager : MonoBehaviour
{
    public static Phase2LevelManager instance;

    public GameObject PotionPrefab;
    public ThePot thePot;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
