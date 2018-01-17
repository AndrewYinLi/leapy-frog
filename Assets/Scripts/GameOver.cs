using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class GameOver : MonoBehaviour {

	Text highscore;
	string temp;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	

		GameObject score = GameObject.FindWithTag("Score");
		StoreHighscore(score.GetComponent<Score>().score);
		highscore = GetComponent<Text>();
		temp = "" + PlayerPrefs.GetInt ("highscore", 0);
		temp = temp.Substring(1,3);
		highscore.text = temp;


	}

	void StoreHighscore(int newHighscore)
	{
		int oldHighscore = PlayerPrefs.GetInt("highscore", 0);    
		if (newHighscore > oldHighscore) {
			PlayerPrefs.SetInt ("highscore", newHighscore);
			PlayerPrefs.Save();

		}
	}
}
