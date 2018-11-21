using UnityEngine;

public class AndroidCameraController : MonoBehaviour {

    public float maxMovementSpeed;
    public GameObject cam;

    float movementSpeed;
    bool steerForward;
    bool steerBackwards;
    bool steerLeft;
    bool steerRight;

    void Start() {
        maxMovementSpeed = maxMovementSpeed * PlayerPrefs.GetFloat ("CameraSpeed", 0.5f);
        movementSpeed = maxMovementSpeed * 1000f;
    }

    void Update() {

        if (steerForward) {
            cam.transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime);
        }

        if (steerBackwards) {
            cam.transform.Translate (-Vector3.forward * movementSpeed * Time.deltaTime);
        }

        if (steerLeft) {
            cam.transform.Translate (Vector3.left * movementSpeed * Time.deltaTime);
        }

        if (steerRight) {
            cam.transform.Translate (-Vector3.left * movementSpeed * Time.deltaTime);
        }

    }      

    public void moveForward() {
        steerForward = true;
    }

    public void stopMovingForward() {
        steerForward = false;
    }      

    public void moveBackwards() {
        steerBackwards = true;
    }

    public void stopMovingBackwards() {
        steerBackwards = false;
    }

    public void moveLeft() {
        steerLeft = true;
    }

    public void stopMovingLeft() {
        steerLeft = false;
    }

    public void moveRight() {
        steerRight = true;
    }

    public void stopMovingRight() {
        steerRight = false;
    }

}