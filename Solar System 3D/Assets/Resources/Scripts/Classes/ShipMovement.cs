using UnityEngine;

public class ShipMovement : DynamicObjectAbstraction {

    public float setMovementSpeed;
	
    void Start() {
		Cursor.visible = false;
		movementSpeed = setMovementSpeed * 100000f;
    }

	void Update () {

        if (Input.GetKey (KeyCode.A)) {
            moveLeft ();
        }

        if (Input.GetKey (KeyCode.D)) {
            moveRight ();
        }
         
        if (Input.GetKey (KeyCode.W)) {
            moveUpward ();
        }

        if (Input.GetKey (KeyCode.S)) {
            moveDownward ();
        }

        gameObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
	}

	void FixedUpdate() {
		gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.left * movementSpeed * Time.deltaTime);
	}

    public override void followCursor ()
    {
		throw new System.NotImplementedException ();
    }

    public override void moveForward ()
    {
        throw new System.NotImplementedException ();
    }

    public override void moveBackwards ()
    {
        throw new System.NotImplementedException ();
    }

    public override void moveLeft ()
    {
        gameObject.GetComponent<Rigidbody> ().AddForce (-Vector3.forward * movementSpeed * Time.deltaTime);
    }

    public override void moveRight ()
    {
        gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.forward * movementSpeed * Time.deltaTime);
    }

    public override void moveUpward ()
    {
        gameObject.GetComponent<Rigidbody> ().AddForce (Vector3.up * movementSpeed * Time.deltaTime);
    }

    public override void moveDownward ()
    {
        gameObject.GetComponent<Rigidbody> ().AddForce (-Vector3.up * movementSpeed * Time.deltaTime);
    }

}