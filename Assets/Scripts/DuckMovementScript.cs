using UnityEngine;
using System.Collections;

public class DuckMovementScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GameObject player = GameObject.FindWithTag("Player");
		PlayerCollision playerCollision = player.GetComponent<PlayerCollision>();
		
		if (gameObject.transform.position.x >= -20.0f) {
			if(playerCollision.grounded)
			{
				this.transform.position = this.transform.position + new Vector3 (-0.325f, 0, 0);
			}
			else{
				this.transform.position = this.transform.position + new Vector3 (-0.325f, 0, 0);
			}
		}
		if (gameObject.gameObject.transform.position.x <= -20.0f || gameObject.gameObject.transform.position.y <= -20.0f) {
			Destroy (gameObject);
		}
	
	}
}
