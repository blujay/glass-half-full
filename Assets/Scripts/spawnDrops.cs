using UnityEngine;
using System.Collections;

public class spawnDrops : MonoBehaviour {

	public GameObject dropPrefab;
	public float randMin = 5.0f;
	public float randMax = 30.0f;

	void Start () {
		float freq = (Random.Range(randMin, randMax));
		InvokeRepeating ("CreateDrop", 0.0f, freq);
	}
	
	void CreateDrop () {
		Instantiate (dropPrefab, transform.position, transform.rotation);
	}
}


