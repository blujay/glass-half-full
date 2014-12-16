using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public static int currentScore = 0;
	public static int highScore;

	public static int currentLevel = 0;
	public static int unlockedLevel;

	public static void CompleteLevel( int dropValue) 

	{

		if (currentLevel < 8) {
			currentLevel += 1;
			//Application.LoadLevel (currentLevel);
			currentScore += dropValue;
			print ("Current score:" + currentScore.ToString());

			} else 

			{
			print ("Game OVER!");
			}	
	}
}
