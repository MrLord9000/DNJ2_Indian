using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{

    [SerializeField] PotionEffect customerPotionEffect;
    private Inventory inventory;

    //private AudioSource source;
    //public AudioClip successSound;
    //public AudioClip failureSound;

    private void Awake()
    {
        inventory = FindObjectOfType<Inventory>();
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/backgrounds/background_sc3_" + Random.Range(1, 6));
        customerPotionEffect = (PotionEffect)Random.Range(0, 15);
        GameObject.Find("Icon").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/interface/effect_" + customerPotionEffect);
        //source = GetComponent<AudioSource>();
    }

    public void GivePotion( Potion potionToSell ){

		if( customerPotionEffect==potionToSell.Action )
        {
			if((int)customerPotionEffect>11)
            {
                inventory.bank += Random.Range(20, 31);
			}
			else if((int)customerPotionEffect>5)
            {
                inventory.bank += Random.Range(10, 21);
            }
			else
            {
                inventory.bank += Random.Range(5, 11);
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
