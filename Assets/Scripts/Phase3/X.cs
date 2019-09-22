using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class X : MonoBehaviour
{
    public void OnMouseDown()
    {
        StartCoroutine(Play(true));
    }

    public static IEnumerator Play( bool end )
    {
        Animator anim = FindObjectOfType<Animator>();
        anim.Play("IndianP3");

        yield return new WaitForSeconds( 5 );

        if( end ) 
            SceneManager.LoadScene(1);
    }
}
