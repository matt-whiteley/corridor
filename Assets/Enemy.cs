using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	int health;
	int criticalPercentage;

	void update(){
		if (criticalPercentage > 0){
			criticalPercentage -= Mathf.CeilToInt((criticalPercentage/100f)* 10f);
		}
	}
}
