using UnityEngine;
using UnityEngine.SceneManagement;

public class Prewarm : MonoBehaviour {

    void Update() {

        if (Input.anyKeyDown) {
            setStartScene ();
        }

    }

    void setStartScene() {
        PlayerPrefs.SetString ("SceneName", "Menu");
        SceneManager.LoadScene ("Loading Screen");    
    }

}