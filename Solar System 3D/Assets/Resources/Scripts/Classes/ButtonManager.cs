using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : ButtonManagerAbstraction {

    public override void loadScene(string sceneName) {
        PlayerPrefs.SetString ("SceneName", sceneName);
        SceneManager.LoadScene ("Loading Screen");       
    }

	public override void restart ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public override void quit () {
		Application.Quit ();
	}

}