using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	public bool grounded = true;
	public float yPosition;
	public bool gameOver = false;
	public bool doubleJump = true;
	void OnCollisionEnter2D (Collision2D col)
	{



		if(col.gameObject.tag == "Floor" && !gameOver)
		{

			grounded = true;
			doubleJump = true;
		}
		if (col.gameObject.tag == "Water" || col.gameObject.tag == "Beak") {

			BoxCollider2D playerCollider = gameObject.GetComponent<BoxCollider2D> ();
			playerCollider.isTrigger = true;
			Vector3 rot = new Vector3 (0, 0, 180);
			gameObject.transform.rotation = Quaternion.Euler (rot);
			//Debug.Log ("GG ur dead");
			gameOver = true;
			GameObject loseSound = GameObject.FindWithTag("LoseSound");
			loseSound.GetComponent<AudioSource>().Play();
		}
		if (col.gameObject.tag == "body" && !gameOver) {

			Vector2 duckForce = new Vector2(0, 200);
			GameObject player = GameObject.FindWithTag("Player");
			GameObject bumpSound = GameObject.FindWithTag("BumpSound");
			bumpSound.GetComponent<AudioSource>().Play();
			player.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			player.GetComponent<Rigidbody2D> ().AddForce (duckForce);

		}

	
	
	}

	void OnCollisionExit2D()
	{

		grounded = false;

	}




}
