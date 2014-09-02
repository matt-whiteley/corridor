using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	int health;
	int maxHealth;
	int criticalPercentage;
	public Texture bar;

	public virtual void Update(){
		if (criticalPercentage > 0){
			criticalPercentage -= Mathf.CeilToInt((criticalPercentage/100f)* 10f);
		}
	}

	public void takeDamage(int damage){
		health -= damage;
		if (health <= 0){
			killSelf();
		}
	}

	public void setHealth(int newHealth){
		health = newHealth;
	}
	public void setMaxHealth(int newHealth){
		maxHealth = newHealth;
	}
	public int getHealth(){
		return health;
	}
	public int getMaxHealth(){
		return maxHealth;
	}
	void killSelf(){
		Object.Destroy(this.gameObject);
	}

	int healthAsPercentage(){
		float temp = (float)health / (float)maxHealth;
		temp *= 100f;
		return Mathf.CeilToInt(temp);
	}

	void OnGUI(){
		Vector3 screenPosition =
			Camera.current.WorldToScreenPoint(transform.position);// gets screen position.
		screenPosition.y = Screen.height - (screenPosition.y + 1);// inverts y
		Rect rect = new Rect(screenPosition.x - 50,
		                     screenPosition.y - 50, healthAsPercentage(), 15);// makes a rect centered at the player ( 100x24 )
		GUI.Label(rect, bar);
	}
}
