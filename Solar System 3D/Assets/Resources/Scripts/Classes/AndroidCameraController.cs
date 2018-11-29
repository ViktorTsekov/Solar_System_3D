using UnityEngine;

public class AndroidCameraController : AndroidCameraControllerAbstraction {

    public float maxMovementSpeed;
    public GameObject cam;

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

    public override void moveForward() {
        steerForward = true;
    }

    public override void stopMovingForward() {
        steerForward = false;
    }      

    public override void moveBackwards() {
        steerBackwards = true;
    }

    public override void stopMovingBackwards() {
        steerBackwards = false;
    }

    public override void moveLeft() {
        steerLeft = true;
    }

    public override void stopMovingLeft() {
        steerLeft = false;
    }

    public override void moveRight() {
        steerRight = true;
    }

    public override void stopMovingRight() {
        steerRight = false;
    }

}