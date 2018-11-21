using UnityEngine;

public class Rotate : MonoBehaviour {

    public float speedOfRotation;

	void Update () {
        transform.Rotate (0f, speedOfRotation, 0f);
	}

}