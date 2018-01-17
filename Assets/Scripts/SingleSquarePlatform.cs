using UnityEngine;
using System.Collections;

public class SingleSquarePlatform : MonoBehaviour {
		





	// Use this for initialization
	void Start () {


		int color = Random.Range(1,8);
		if (color == 1) {
			GetComponent<SpriteRenderer> ().color = Color.blue;
		} 
		else if (color == 2) {
			GetComponent<SpriteRenderer> ().color = Color.green;
		}
		else if (color == 3) {
			GetComponent<SpriteRenderer> ().color = Color.cyan;
		}
		else if (color == 4) {
			GetComponent<SpriteRenderer> ().color = Color.magenta;
		}
		else if (color == 5) {
			GetComponent<SpriteRenderer> ().color = Color.red;
		}
		else if (color == 6) {
			GetComponent<SpriteRenderer> ().color = Color.yellow;
		}
		else if (color == 7) {
			GetComponent<SpriteRenderer> ().color = Color.gray;
		}



	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.FindWithTag("Player");
		PlayerCollision playerCollision = player.GetComponent<PlayerCollision>();
		bool gg = player.GetComponent<PlayerCollision> ().gameOver;
		if (gameObject.transform.position.x >= -20.0f && !gg) {


			if(playerCollision.grounded)
			{
				this.transform.position = this.transform.position + new Vector3 (-0.15f, 0, 0);
			}
			else{
				this.transform.position = this.transform.position + new Vector3 (-0.15f, 0, 0);
			}
		}
		if (gameObject.gameObject.transform.position.x <= -20.0f) {
			Destroy (gameObject);
		}
	
	}
}
