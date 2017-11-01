using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour {

	public GameObject pausepanel, pausebutton;





	public void PauseGame (){
		Time.timeScale = 0;
		pausebutton.SetActive (false);
		pausepanel.SetActive (true);
	
	}

	public void resumeGame (){
		Time.timeScale = 1;
		pausebutton.SetActive (true);
		pausepanel.SetActive (false);
	
	}

	public void Quit ()
	{
		Application.Quit();
	}

	public void Retry ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
		Songcontrol.songlength = 0;
		Songcontrol.i = 0;
		NotesControl.totalScore = 0;
	}
}
