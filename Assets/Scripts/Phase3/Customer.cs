using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
	private enum PotionEffect
	{
	    speed,
	    slow,
	    large,
	    smal,
	    multiplication,
	    halucination,
	    invis,
	    confusion,
	    twist,
	    drunk,
	    blackNWhite,
	    rain,
	    strength,
	    levitation,
	    poison
	}

	private string CustomerPotionEffect;

	void setCustomerPotionEffect(){
		//CustomerPotionEffect=/*Random from PotionEffect*/
	}

	int sellPotionToCustomer(GameObject potion){
		if(CustomerPotionEffect==potion.potionEffect){
			if(/*effect from 2 tier 1 flowers*/){
				return 1;
			}
			else if(/*effect from 2 tier 2 flowers*/){
				return 3;
			}
			else/*effect from 1 tier 1 and 1 tier 2 flower*/{
				return 2;
			}
		}
		else return 0;
	}

    // Start is called before the first frame update
    void Start()
    {
        setCustomerPotionEffect();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
