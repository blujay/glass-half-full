using UnityEngine;
using System.Collections;
public class createNew : MonoBehaviour 
{
	public Transform prefab;
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "drop") 
		{
			Destroy (col.gameObject);
			Destroy (gameObject);
			Instantiate(prefab, transform.position, transform.rotation);
			prefab.tag = "vitality";
		}
	}
}
