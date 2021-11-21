using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerMouvement : MonoBehaviour {

	//This is a reference to the Rigidbody component called "PlayerRB"
	public Rigidbody PlayerRB;

	public float Force =2000f; 
	public float SideForce =500f; 



	// Use this for initialization
	/*void Start () {

		//Add Force to the player (cube)
		PlayerRB.AddForce (0, 200, 500);

	}*/
	
	// We marked this "Fixed" Update bacause we are using it to mess with physics  
	void FixedUpdate () 
	{
		//Add a force 
		PlayerRB.AddForce (0, 0, Force * Time.deltaTime);


		//Add a side force 
		//If the player is pressing the "p" key
		if ( Input.GetKey("p") )
		{
			//Add force to the right
			PlayerRB.AddForce (SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange );

		}

		//If the player is pressing the "a" key
		if ( Input.GetKey("a") )
		{
			//Add force to the left
			PlayerRB.AddForce (-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		}

		if (PlayerRB.position.y < -1f) 
		{

			FindObjectOfType<GameManager>().EndGame();
		}




	}
}
