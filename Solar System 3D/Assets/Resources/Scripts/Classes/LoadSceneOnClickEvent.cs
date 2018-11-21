using UnityEngine;

public class LoadSceneOnClickEvent : MonoBehaviour {

    public KeyCode theTrigger;

    private GameObject buttonManagerReference;

    void Start() {
        buttonManagerReference = GameObject.Find ("Button Manager");
    }

    void Update () {

        if (Input.GetKeyDown(theTrigger)) {
            buttonManagerReference.SendMessage ("loadScene", SendMessageOptions.DontRequireReceiver);
        }

    }

}