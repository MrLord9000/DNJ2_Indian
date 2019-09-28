using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDiscSampling : MonoBehaviour
{
	public GameObject flower;

	public string colorGroup;

	public float radius = 1;
	public Vector2 regionSize = Vector2.one;
	public Vector2 regionShift = Vector2.one;
	public int rejectionSamples = 30;
	public float displayRadius =1;

	List<Vector2> points;

    void OnValidate(){
    	points = PoissonDiscSampling.GeneratePoints(radius,regionSize,regionShift,rejectionSamples);
    }

    void  OnDrawGizmos(){
    	Gizmos.DrawWireSphere(regionSize/2,regionSize.x/2);
    	if (points != null){
    		foreach(Vector2 point in points){
    			Gizmos.DrawSphere(point,displayRadius);
    		}
    	}
    }

    FlowerColor colorMyFlower(string colorGroup){
    	float chanceForMix = Random.value;
    	switch(colorGroup){
    		case "red":
    			if (chanceForMix<0.9f) return FlowerColor.red;
    			else if(chanceForMix<0.95f) return FlowerColor.orange;
    			else return FlowerColor.purple;
    		case "yellow":
    			if(chanceForMix<0.9f) return FlowerColor.yellow;
    			else if(chanceForMix<0.95f) return FlowerColor.orange;
    			else return FlowerColor.green;
    		case "blue":
    			if(chanceForMix<0.9f) return FlowerColor.blue;
    			else if(chanceForMix<0.95f) return FlowerColor.green;
    			else return FlowerColor.purple;
    		case "black":
    			return FlowerColor.black;
    		case "white":
    			if(chanceForMix<0.95f) return FlowerColor.pink;
    			else return FlowerColor.white;
    		default:
    			 return FlowerColor.white;
    	}
    }

    void Start(){
    	OnValidate();
    	foreach(Vector2 point in points){
    		GameObject created_flower = Instantiate(flower,new Vector3(point.x,point.y,0f),Quaternion.identity,transform);
    		created_flower.GetComponent<Flower>().Color = colorMyFlower(colorGroup);
    	}
    }
}
