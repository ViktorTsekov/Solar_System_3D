using UnityEngine;

public abstract class AndroidCameraControllerAbstraction : MonoBehaviour, IandroidCameraController {

    public float movementSpeed { get; set;}
    public bool steerForward { get; set;}
    public bool steerBackwards { get; set;}
    public bool steerLeft { get; set;}
    public bool steerRight { get; set;}

    public abstract void moveForward();

    public abstract void stopMovingForward();

    public abstract void moveBackwards();

    public abstract void stopMovingBackwards();

    public abstract void moveLeft();

    public abstract void stopMovingLeft();

    public abstract void moveRight();

    public abstract void stopMovingRight();

}