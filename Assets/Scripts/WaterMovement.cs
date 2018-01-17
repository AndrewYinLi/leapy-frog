using UnityEngine;
using System.Collections;

public class WaterMovement : MonoBehaviour {
	public GameObject water;
	private int index = 0;


	// Use this for initialization
	void Start () {
		//Instantiate(water);
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.x >= -0.7f){

			if (this.index < 5) {
				this.transform.position = this.transform.position + new Vector3 (-0.02f, 0, 0);
				this.index++;
			} else if (this.index >= 5 && this.index < 20) {
				this.transform.position = this.transform.position + new Vector3 (-0.02f, 0.01f, 0);
				this.index++;
			} else if (this.index >= 20 && this.index < 35) {
				this.transform.position = this.transform.position + new Vector3 (-0.02f, -0.01f, 0);
				this.index++;
			} else {
				this.index = 0;
				
			}

		}
		else{
			//Debug.Log("X: " + gameObject.transform.position.x + " / Y: " + gameObject.transform.position.y);
			Instantiate (water, new Vector3(7.65f, -10.8f, 0), transform.rotation);
			Destroy(gameObject);
		

		} 

			




	}
}
