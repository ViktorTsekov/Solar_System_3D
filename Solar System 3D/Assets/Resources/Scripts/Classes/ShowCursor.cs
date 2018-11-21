using UnityEngine;

public class ShowCursor : MonoBehaviour {

	void Update () {

        if (Input.GetKeyDown (KeyCode.Escape)) {
            Cursor.visible = true;
            gameObject.GetComponent<CameraMovement> ().enabled = false;
        }

        if (Input.GetMouseButton (0)) {
            Cursor.visible = false;
            gameObject.GetComponent<CameraMovement> ().enabled = true;
        }

	}

}