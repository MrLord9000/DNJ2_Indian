using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighligthCentre : MonoBehaviour
{
    Corner oldH = null;
    Corner newH = null;
    
    // Update is called once per frame
    void Update()
    {
        oldH = newH;
        RaycastHit2D hit = Physics2D.Raycast(Vector2.zero, Camera.main.ScreenToWorldPoint(Input.mousePosition), 1000, 1<<9 );
        newH = hit.collider?.GetComponent<Corner>();
        if( newH != oldH )
        {

            oldH?.TurnOff();
            newH?.TurnOn();
            GameManager.Instance.selectedFowerColor = newH?.color;
        }


    }

}
