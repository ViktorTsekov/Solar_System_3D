using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    
    void Start() {
        StartCoroutine (playScene ());
    }

    public IEnumerator playScene() {
        string sceneName = PlayerPrefs.GetString ("SceneName");
        yield return new WaitForSeconds (3f);
        SceneManager.LoadScene (sceneName);
    }
        
}