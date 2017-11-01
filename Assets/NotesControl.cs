using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class NotesControl : MonoBehaviour {

	public Transform burst;

	public static float totalScore = 0;

	public AudioSource myAudio;

	//public static float slider=0;


	// Use this for initialization
	void Start () {

		if (gameObject.name == "Note1(Clone)") {
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, -90, 0);
		}
		if (gameObject.name == "Note2(Clone)") {
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, -90, 0);
		}	
		if (gameObject.name == "Note3(Clone)") {
			GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, -90, 0);
		}	
	}
	
	// Update is called once per frame
	void Update () {

		if ((Songcontrol.destroyA == "y") && (gameObject.name == "Note1(Clone)") && (transform.position.y <= 75)) {
			Destroy (gameObject);
			Instantiate (burst, transform.position, transform.rotation);
			totalScore = totalScore + 1;
			Songcontrol.destroyA = "n";
			Debug.Log (Songcontrol.destroyA);
			PressButton1.value = false;
			 
		}
		if ((Songcontrol.destroyB == "y") && (gameObject.name == "Note2(Clone)") && (transform.position.y <= 75)) {
			Destroy (gameObject);
			Instantiate (burst, transform.position, transform.rotation);
			totalScore = totalScore + 1;
			Songcontrol.destroyB = "n";
			PressButton2.value = false;
		
		}
		if ((Songcontrol.destroyC == "y") && (gameObject.name == "Note3(Clone)") && (transform.position.y <= 75)) {
			Destroy (gameObject);
			Instantiate (burst, transform.position, transform.rotation);
			totalScore = totalScore + 1;
			Songcontrol.destroyC = "n";
			PressButton3.value = false;
		}	
	}
		
	/*
	void OnTriggerEnter2D () {
		GetComponent<SpriteRenderer>().color = new Color (0, 1, 0);
	}*/

	void OnTriggerExit2D () {
		GetComponent<SpriteRenderer> ().color = new Color (1, 0, 0);
		Destroy (gameObject, .5f);
	}


}
