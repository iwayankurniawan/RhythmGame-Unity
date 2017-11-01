using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioSource songTitle;


	// Use this for initialization
	void Awake () {

		if (Songcontrol.songlength >= 4) {

			//songTitle.clip = clip;
			songTitle.Play ();
		
		}


	}
		
}
