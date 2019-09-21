using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDiscSampling : MonoBehaviour
{
	public GameObject flower;

	public float radius = 1;
	public Vector2 regionSize = Vector2.one;
	public Vector2 regionShift = Vector2.one;
	public int rejectionSamples = 30;
	public float displayRadius =1;

	List<Vector2> points;

    void OnValidate(){
    	points = PoissonDiscSampling.GeneratePoints(radius,regionSize,regionShift,rejectionSamples);
    }

    /*void  OnDrawGizmos(){
    	Gizmos.DrawWireSphere(regionSize/2,regionSize.x/2);
    	if (points != null){
    		foreach(Vector2 point in points){
    			Gizmos.DrawSphere(point,displayRadius);
    		}
    	}
    }*/

    void Start(){
    	OnValidate();
    	foreach(Vector2 point in points){
    		Instantiate(flower,new Vector3(point.x,point.y,0f),Quaternion.identity);
    	}
    }
}
