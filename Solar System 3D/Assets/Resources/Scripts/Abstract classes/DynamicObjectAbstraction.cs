using UnityEngine;

public abstract class DynamicObjectAbstraction : MonoBehaviour, Imovement, IfollowCursor {

	public float movementSpeed { get; set;}
    public float mouseSensitivity { get; set;}

    public abstract void followCursor();

    public abstract void moveForward();

    public abstract void moveBackwards();

    public abstract void moveLeft();

    public abstract void moveRight();

    public abstract void moveUpward();

    public abstract void moveDownward();

}