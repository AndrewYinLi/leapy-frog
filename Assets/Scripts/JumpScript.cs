using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour {




	public Vector2 jumpForce = new Vector2(0, 0);



	public void AClick()
	{
		GameObject player = GameObject.FindWithTag("Player");
		GameObject jumpSound = GameObject.FindWithTag("JumpSound");
		PlayerCollision playerCollision = player.GetComponent<PlayerCollision>();
		if (playerCollision.grounded == true) {
			player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			player.GetComponent<Rigidbody2D> ().AddForce (jumpForce);
			jumpSound.GetComponent<AudioSource>().Play();


		} else if (playerCollision.doubleJump == true) {
			player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			player.GetComponent<Rigidbody2D> ().AddForce (jumpForce);
			playerCollision.doubleJump = false;
			jumpSound.GetComponent<AudioSource>().Play();
		}
	}


}
