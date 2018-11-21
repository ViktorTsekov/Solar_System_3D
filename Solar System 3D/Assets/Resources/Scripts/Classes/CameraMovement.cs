using UnityEngine;

public class CameraMovement : DynamicObjectAbstraction {

    public KeyCode forwardKey;
    public KeyCode backwardsKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode upwardKey;
    public KeyCode downwardKey;

    public float maxMovementSpeed;
    public float maxMouseSensitivity;

    private float mouseXposition = 0f;
    private float mouseYposition = 0f;

	void Start () {
        Cursor.visible = false;
        maxMovementSpeed = maxMovementSpeed * PlayerPrefs.GetFloat ("CameraSpeed", 0.5f);
        movementSpeed = maxMovementSpeed * 1000f;
        mouseSensitivity = maxMouseSensitivity * PlayerPrefs.GetFloat ("CameraSensitivity", 0.5f);
	}
	
	void Update () {
        followCursor ();

        if (Input.GetKey (forwardKey)) {
            moveForward ();
        }

        if (Input.GetKey (backwardsKey)) {
            moveBackwards ();
        }

        if (Input.GetKey (leftKey)) {
            moveLeft ();
        }

        if (Input.GetKey (rightKey)) {
            moveRight ();
        }

        if (Input.GetKey (upwardKey)) {
            moveUpward ();
        }

        if (Input.GetKey (downwardKey)) {
            moveDownward ();
        }          

	}

    public override void followCursor ()
    {
        mouseXposition += mouseSensitivity * Input.GetAxis ("Mouse X");
        mouseYposition -= mouseSensitivity * Input.GetAxis ("Mouse Y");

        transform.eulerAngles = new Vector3(mouseYposition, mouseXposition, 0f);
    }

    public override void moveForward ()
    {
        transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime);
    }

    public override void moveBackwards ()
    {
        transform.Translate (-Vector3.forward * movementSpeed * Time.deltaTime);
    }

    public override void moveLeft ()
    {
        transform.Translate (Vector3.left * movementSpeed * Time.deltaTime);
    }

    public override void moveRight ()
    {
        transform.Translate (-Vector3.left * movementSpeed * Time.deltaTime);
    }

    public override void moveUpward ()
    {
        transform.Translate (Vector3.up * movementSpeed * Time.deltaTime);
    }

    public override void moveDownward ()
    {
        transform.Translate (-Vector3.up * movementSpeed * Time.deltaTime);
    }

}