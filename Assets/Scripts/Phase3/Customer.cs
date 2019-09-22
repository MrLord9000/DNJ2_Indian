using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{

    [SerializeField] PotionEffect customerPotionEffect;

    //private AudioSource source;
    //public AudioClip successSound;
    //public AudioClip failureSound;

    private void Awake()
    {
        customerPotionEffect = (PotionEffect)Random.Range(0, 15);
        //source = GetComponent<AudioSource>();
    }

    public void GivePotion( Potion potionToSell ){

		if( customerPotionEffect==potionToSell.Action )
        {
			if((int)customerPotionEffect>11)
            {
                GameManager.Bank += Random.Range(20, 31);
			}
			else if((int)customerPotionEffect>5)
            {
                GameManager.Bank += Random.Range(10, 21);
            }
			else
            {
                GameManager.Bank += Random.Range(5, 11);
            }
            //source.clip=succesSound;
            //source.Play();
		}
        else{
            //source.clip=failureSound;
            //source.Play();
        }
        Destroy(potionToSell.gameObject);
        Destroy(gameObject);    
	}
}
