using UnityEngine;
using System.Collections;
public class createNew : MonoBehaviour 
{
	public Transform prefab;
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "blood") 
		{
			Destroy (col.gameObject);
			Instantiate(gameObject, transform.position, transform.rotation);
		}

	}
}