using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	//Reference to the PLayerMovemet script ! 
	public PLayerMouvement movement;


	//Function runs when we hit an object , 
	//We get information about the collision and we call it "collisionInfo" 
	void OnCollisionEnter (Collision collisionInfo)
	{
		//Check if the object we collided with has a tag called "Obstacle" !
		if (collisionInfo.collider.tag == "Obstacle") 
		{
			//Console message !
			//Debug.Log ("We hit an obstacle!");

			//Disabled the player mouvement 
			movement.enabled =false;
			FindObjectOfType<GameManager>().EndGame();


		}





	}



}
