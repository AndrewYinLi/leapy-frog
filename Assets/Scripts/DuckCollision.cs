using UnityEngine;
using System.Collections;

public class DuckCollision : MonoBehaviour {
	


	
	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			PolygonCollider2D playerCollider = gameObject.GetComponent<PolygonCollider2D> ();
			Rigidbody2D playerRigidbody = gameObject.GetComponentInParent<Rigidbody2D>();
			playerCollider.isTrigger = true;
			playerRigidbody.isKinematic = false;
			Vector3 rot = new Vector3 (0, 0, 180);
			gameObject.transform.rotation = Quaternion.Euler (rot);
			this.transform.position = this.transform.position + new Vector3 (-0.325f, -0.5f, 0);
		}

		
	}
	

	
	
	
	
}
