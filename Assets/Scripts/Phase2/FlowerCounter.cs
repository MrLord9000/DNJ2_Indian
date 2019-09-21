using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class FlowerCounter : MonoBehaviour
{
    private Flower flower;
    private SpriteRenderer flowerRenderer;

    public int number;

    // Start is called before the first frame update
    void Start()
    {
        flower = GetComponentInChildren<Flower>();
        flowerRenderer = flower.gameObject.GetComponent<SpriteRenderer>();
        dots = GameObject.Find("Dot");
    }

    // Update is called once per frame
    void Update()
    {

        if( number == 0 )
        {
            flowerRenderer.color *= new Color(1,1,1,0.5f);
            ShowDots(0);
        }
        else
        {
            flowerRenderer.color += new Color(0, 0, 0, 1);

            if( number > 2 && number < 10 )
            {
                ShowDots(number);
            }
            else
            {
                ShowDots(0);
            }

        }
    }

    public void ShowDots( int n )
    {
        for (int i = 0; i < n; i++)
        {
            dots[i].gameObject.SetActive(true);
        }
        for (int i = n; i < 9; i++)
        {
            dots[i].gameObject.SetActive(false);
        }
    }
}
*/