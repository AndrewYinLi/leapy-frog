using UnityEngine;
using System.Collections;

public class ScoreCollision : MonoBehaviour {

	bool fresh = true;
	int localScore;
	string localScoreStr;
	string s1;
	string s2;
	string s3;
	private SpriteRenderer ScoreDosSprite;
	private SpriteRenderer ScoreTresSprite;
	private SpriteRenderer ScoreUnoSprite;
	public Sprite sprite1;
	public Sprite sprite2;
	public Sprite sprite3;
	public Sprite sprite4;
	public Sprite sprite5;
	public Sprite sprite6;
	public Sprite sprite7;
	public Sprite sprite8;
	public Sprite sprite9;
	public Sprite sprite0;


	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Player" && fresh)
		{
			GameObject score = GameObject.FindWithTag("Score");
			score.GetComponent<Score>().score += 1;
			localScore = score.GetComponent<Score>().score;
			localScoreStr = "" + localScore;
			s2 = localScoreStr.Substring(1,1);
			s3 = localScoreStr.Substring(2,1);
			s1 = localScoreStr.Substring(3,1);
			GameObject ScoreUno = GameObject.FindWithTag("ScoreUno");
			GameObject ScoreDos = GameObject.FindWithTag("ScoreDos");
			GameObject ScoreTres = GameObject.FindWithTag("ScoreTres");
			ScoreDosSprite = ScoreUno.GetComponent<SpriteRenderer>();
			ScoreTresSprite = ScoreDos.GetComponent<SpriteRenderer>();
			ScoreUnoSprite = ScoreTres.GetComponent<SpriteRenderer>();
			if(s1 == "1")
			{
				ScoreUnoSprite.sprite = sprite1; 
			}
			else if(s1 == "2")
			{
				ScoreUnoSprite.sprite = sprite2; 
			}
			else if(s1 == "3")
			{
				ScoreUnoSprite.sprite = sprite3; 
			}
			else if(s1 == "4")
			{
				ScoreUnoSprite.sprite = sprite4; 
			}
			else if(s1 == "5")
			{
				ScoreUnoSprite.sprite = sprite5; 
			}
			else if(s1 == "6")
			{
				ScoreUnoSprite.sprite = sprite6; 
			}
			else if(s1 == "7")
			{
				ScoreUnoSprite.sprite = sprite7; 
			}
			else if(s1 == "8")
			{
				ScoreUnoSprite.sprite = sprite8; 
			}
			else if(s1 == "9")
			{
				ScoreUnoSprite.sprite = sprite9; 
			}
			else
			{
				ScoreUnoSprite.sprite = sprite0; 
			}

			if(s2 == "1")
			{
				ScoreDosSprite.sprite = sprite1; 
			}
			else if(s2 == "2")
			{
				ScoreDosSprite.sprite = sprite2; 
			}
			else if(s2 == "3")
			{
				ScoreDosSprite.sprite = sprite3; 
			}
			else if(s2 == "4")
			{
				ScoreDosSprite.sprite = sprite4; 
			}
			else if(s2 == "5")
			{
				ScoreDosSprite.sprite = sprite5; 
			}
			else if(s2 == "6")
			{
				ScoreDosSprite.sprite = sprite6; 
			}
			else if(s2 == "7")
			{
				ScoreDosSprite.sprite = sprite7; 
			}
			else if(s2 == "8")
			{
				ScoreDosSprite.sprite = sprite8; 
			}
			else if(s2 == "9")
			{
				ScoreDosSprite.sprite = sprite9; 
			}
			else
			{
				ScoreDosSprite.sprite = sprite0; 
			}
			if(s3 == "1")
			{
				ScoreTresSprite.sprite = sprite1; 
			}
			else if(s3 == "2")
			{
				ScoreTresSprite.sprite = sprite2; 
			}
			else if(s3 == "3")
			{
				ScoreTresSprite.sprite = sprite3; 
			}
			else if(s3 == "4")
			{
				ScoreTresSprite.sprite = sprite4; 
			}
			else if(s3 == "5")
			{
				ScoreTresSprite.sprite = sprite5; 
			}
			else if(s3 == "6")
			{
				ScoreTresSprite.sprite = sprite6; 
			}
			else if(s3 == "7")
			{
				ScoreTresSprite.sprite = sprite7; 
			}
			else if(s3 == "8")
			{
				ScoreTresSprite.sprite = sprite8; 
			}
			else if(s3 == "9")
			{
				ScoreTresSprite.sprite = sprite9; 
			}
			else
			{
				ScoreTresSprite.sprite = sprite0; 
			}



			fresh = false;
		}

		
	}
}
