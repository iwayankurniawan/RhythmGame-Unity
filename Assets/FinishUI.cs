using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishUI : MonoBehaviour {

	  
	public void Quit ()
	{
		Application.Quit();
	}

	public void Retry ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		Songcontrol.songlength = 0;
		Songcontrol.i = 0;
		NotesControl.totalScore = 0;

	}
		
}
