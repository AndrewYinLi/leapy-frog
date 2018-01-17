using UnityEngine;
using System.Collections;

public class GenerateObstacles : MonoBehaviour {
	public GameObject singleSquarePlatform;
	public GameObject duck;
	public bool firstSSP = true;
	public float previousSSPY;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("GenerateSSP", 0.6f, 1.8f);
	
	}
	
	// Update is called once per frame
	void GenerateSSP () {

		if (firstSSP) {
			Instantiate (singleSquarePlatform, new Vector3 (19.0f, -10.0f, 0), transform.rotation);
			previousSSPY = -10.0f;
			firstSSP = false;
		} 
		else {
			//defining variables
			int randomInt = Random.Range (1, 6);
			int randomInt2 = Random.Range(1,4);
			int operation = Random.Range(1,3);
			int operation2 = Random.Range(1,3);
			int duckFactor = Random.Range(1,3);
			float xConstant;
			float yVariable;
			float xVariable;

			//determining float yVariable
			if(randomInt == 1)
			{
				yVariable = 0.5f;
			}
			else if(randomInt == 2)
			{
				yVariable = 0.75f;
			}
			else if(randomInt == 3)
			{
				yVariable = 1.0f;
			}
			else if(randomInt == 4)
			{
				yVariable = 1.25f;
			}
			else
			{
				yVariable = 1.5f;
			}
			//determining + or -
			if(operation == 1)
			{
				yVariable = previousSSPY += yVariable;
			}
			else{
				yVariable = previousSSPY -= yVariable;
			}

			//determining how much to change x by
			if(randomInt2 == 1)
			{
				xConstant = 0.25f;
			}
			else if(randomInt2 == 2)
			{
				xConstant = 0.4f;
			}
			else{
				xConstant = 0.55f;
			}
			//determining whether to subtract or add
			if(operation2 == 1)
			{
				xVariable = 19.5f + xConstant;
			}
			else{
				xVariable = 19.5f - xConstant;
			}
			//what to instantiate
			if(yVariable >= -12.5f && yVariable <= -1.0f){

				Instantiate (singleSquarePlatform, new Vector3 (xVariable, yVariable, 0), transform.rotation);

			}
			else if(yVariable <= -12.5f)
			{
				Instantiate (singleSquarePlatform, new Vector3 (20.0f, -11f, 0), transform.rotation);
				previousSSPY += 0.75f;
			}
			else{
				Instantiate (singleSquarePlatform, new Vector3 (20.0f, -2f, 0), transform.rotation);
				previousSSPY -= -0.75f;
			}

			if(duckFactor == 1) 
			{
				int randomVariance = Random.Range(1,4);
				float yVariance;
				if(randomVariance == 1)
				{
					yVariance = 6.85f;
				}
				else if (randomVariance == 2)
				{
					yVariance = 7f;
				}
				else{
					yVariance = 7.2f;
				}
				yVariable += yVariance;
				Instantiate (duck, new Vector3 (xVariable, yVariable, 0), transform.rotation);
			}



		}

	}
}
