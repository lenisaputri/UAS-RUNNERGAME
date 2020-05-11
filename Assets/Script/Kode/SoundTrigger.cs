using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour{

	public AudioSource myAudio;
	public AudioClip wallHit;

	// Use this for initialization
	void Start()
	{
		myAudio = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			myAudio.PlayOneShot(wallHit, 1);
		}
	}
}
