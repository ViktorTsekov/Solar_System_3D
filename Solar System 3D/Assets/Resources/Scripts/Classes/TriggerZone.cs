using UnityEngine;

public class TriggerZone : MonoBehaviour {

	public bool destroyOnExit;
    public GameObject dialogueWindow;

    void OnTriggerEnter() {
        dialogueWindow.SetActive (true);
    }
	
    void OnTriggerExit() {

		if (destroyOnExit) {
			dialogueWindow.SetActive (false);
		}

    }

}