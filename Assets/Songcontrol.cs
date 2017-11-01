using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Songcontrol : MonoBehaviour {



	public static int i=0;

	public static int j=1;

	//to make which button are running
	public Transform Button1;
	public Transform Button2;
	public Transform Button3;

	public Transform scoreObj;
	public Transform scoreFinal;
	public static float songlength =0;

	//to make which button must be press in the game
	public KeyCode keyA;
	public KeyCode keyS;
	public KeyCode keyD;

	//Destroy a note
	public static string destroyA = "n";
	public static string destroyB = "n";
	public static string destroyC = "n";


	public GameObject GameoverUI;
	public GameObject FinalScore;

	public Slider slider;


	void FixedUpdate () {

		//increase time in every frame
		Debug.Log (SongArray.song [i, 0]/30);
		Debug.Log (songlength);
		songlength += Time.deltaTime;

		if ((songlength >= (SongArray.song [i, 0])/30) && (songlength <= ((SongArray.song [i, 0])/30 + .1))) {


		 if (SongArray.song [i, 1] == 1 && SongArray.song [i, 2] == 1 ) {
				Instantiate (Button1, Button1.position, Button1.rotation);
				Instantiate (Button2, Button2.position, Button2.rotation);
			}

			else if (SongArray.song [i, 1] == 1 && SongArray.song [i, 3] == 1 ) {
				Instantiate (Button1, Button1.position, Button1.rotation);
				Instantiate (Button3, Button3.position, Button3.rotation);
			}
			else if (SongArray.song [i, 2] == 1 && SongArray.song [i, 3] == 1 ) {
				Instantiate (Button2, Button2.position, Button2.rotation);
				Instantiate (Button3, Button3.position, Button3.rotation);
			}

			else if (SongArray.song [i, 1] == 1) {
				Instantiate (Button1, Button1.position, Button1.rotation);

			} else if (SongArray.song [i, 2] == 1) {
				Instantiate (Button2, Button2.position, Button2.rotation);

			} else if (SongArray.song [i, 3] == 1) {
				Instantiate (Button3, Button3.position, Button3.rotation);
			}

			i = i + 1;

			//Debug.Log (i);

			scoreObj.GetComponent<TextMesh> ().text =  NotesControl.totalScore.ToString () ; 
			scoreFinal.GetComponent<TextMesh> ().text = NotesControl.totalScore.ToString () ;



		} 
		else if ((songlength >= 69) && (songlength <= 69 + .1)) 
		{
			EndGame ();

		}

		if (NotesControl.totalScore == j) {
			
			slider.value = slider.value + 0.02f;
			j = j + 1;
		}
			
			
	}

	void OnTriggerStay2D (Collider2D other)
	{
		//if button1 collide and the button A is press then destroy A
		if ((PressButton1.value == true) && (other.gameObject.name == "Note1(Clone)")) {
			destroyA= "y";
			PressButton1.value = false;

		}
		if ((PressButton2.value == true) && (other.gameObject.name == "Note1(Clone)")) {
			destroyB= "y";
			PressButton2.value = false;
	
		}
		if ((PressButton3.value == true) && (other.gameObject.name == "Note1(Clone)")) {
			destroyC= "y";
			PressButton3.value = false;

		}
	}

	void EndGame ()
	{
		GameoverUI.SetActive (true);
		FinalScore.SetActive (true);
	}
}
