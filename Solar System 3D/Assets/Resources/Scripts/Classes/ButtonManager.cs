using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : ButtonManagerAbstraction {

    public GameObject instructions;

    public override void loadScene(string sceneName) {
        PlayerPrefs.SetString ("SceneName", sceneName);
        SceneManager.LoadScene ("Loading Screen");       
    }

    public override void playAnimationOnInstructions ()
    {

        if (instructionsIndex % 2 == 0) {
            instructions.GetComponent<Animation> ().Play ("Instructions in");
        } else {
            instructions.GetComponent<Animation> ().Play ("Instructions out");
        }

        instructionsIndex++;
    }

	public override void restart ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public override void quit () {
		Application.Quit ();
	}

}