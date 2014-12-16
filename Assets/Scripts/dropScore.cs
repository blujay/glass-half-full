using UnityEngine;
using System.Collections;



public class dropScore : MonoBehaviour

{

	void OnTriggerEnter (Collider col)
	{
		int scoreBall = 0;

		if (col.gameObject.tag == "drop") {
			scoreBall = 50;
		}
		else if (col.gameObject.tag == "vitality") {
			scoreBall = 100;
		}
		else if (col.gameObject.tag == "gold") {
			scoreBall = 500;
		}
		else if(col.gameObject.tag == "toxic") {
			scoreBall = -100;
		}
		GameManager.CompleteLevel(scoreBall);
	}
}
