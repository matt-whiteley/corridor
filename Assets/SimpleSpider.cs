using UnityEngine;
using System.Collections;


public class SimpleSpider : Enemy {

	void Start(){
		this.setHealth(100);
		this.setMaxHealth(100);
	}

	public override void Update(){
		base.Update();
		//this.takeDamage(1); //test health bar
	}
}
