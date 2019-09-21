using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{

	[SerializeField] PotionEffect customerPotionEffect=(PotionEffect)Random.Range(0,15);

	int givePotion(Potion potionToSell){
		if(customerPotionEffect==potionToSell.Action){
			if((int)customerPotionEffect>11){
				return 3;
			}
			else if((int)customerPotionEffect>5){
				return 2;
			}
			else{
				return 1;
			}
		}
		else return 0;
	}
}
