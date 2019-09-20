using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class FlowerSlot : MonoBehaviour
{
    private BoxCollider2D callider;

    // Start is called before the first frame update
    void Start()
    {
        callider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
