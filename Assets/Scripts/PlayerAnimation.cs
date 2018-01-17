using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {


	private Animator animator;
	private GameObject jumpBox;
	private BoxCollider2D jumpBoxCollider;

	void Start()
	{
		animator = this.GetComponent<Animator>();
		jumpBox = GameObject.FindWithTag("JumpBox");
		jumpBoxCollider = jumpBox.GetComponent<BoxCollider2D>();
	}
	

	void Update()
	{
		GameObject player = GameObject.FindWithTag("Player");
		PlayerCollision playerCollision = player.GetComponent<PlayerCollision>();
		if(!playerCollision.gameOver){
			gameObject.transform.position = new Vector3 (-5.9f,gameObject.transform.position.y,0);
			Vector3 rot = new Vector3 (0, 0, 0);
			gameObject.transform.rotation = Quaternion.Euler (rot);
		}
		float newY = player.transform.position.y + 1.55f;
		jumpBox.transform.position = new Vector3(-6.0f,newY,0.0f);

		//PlayerCollision playerCollision = player.GetComponent<PlayerCollision>();

		if (playerCollision.grounded == true) 
		{
			animator.SetInteger ("Grounded", 0);

			jumpBoxCollider.enabled = false;

		} 
		else 
		{
			animator.SetInteger ("Grounded", 1);
			
		
			jumpBoxCollider.enabled = true;

		}

	}
}
