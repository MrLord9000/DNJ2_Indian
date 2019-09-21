using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{

    [SerializeField] PotionEffect customerPotionEffect;

    private void Awake()
    {
        customerPotionEffect = (PotionEffect)Random.Range(0, 15);
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
		}
        Destroy(potionToSell.gameObject);
        Destroy(gameObject);    
	}
}
