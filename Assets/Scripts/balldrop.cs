using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
	public class CollisionAudioPlayer : MonoBehaviour { AudioSource asrc;
		void Start()
		{
			asrc = GetComponent(typeof(AudioSource)) as AudioSource;
		}
		
		void OnCollisionEnter(Collision other)
		{
			if(asrc != null)
			{
				asrc.Play();
			}
		}
	}
}
