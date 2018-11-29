using UnityEngine;

public class StopOrbitingOfPlanets : MonoBehaviour {

    GameObject[] planets;
    bool dontOrbit;

	void Start () {
        planets = GameObject.FindGameObjectsWithTag ("Planet");
	}
	
    void Update() {
        
        if (Input.GetKeyDown (KeyCode.Space)) {
            changeOrbitingState ();
        }

    }

    public void changeOrbitingState() {
        dontOrbit = !dontOrbit;

        if (dontOrbit) {

            foreach (GameObject obj in planets) {
                obj.GetComponent<Orbit> ().enabled = false;
            }

        } else {

            foreach (GameObject obj in planets) {
                obj.GetComponent<Orbit> ().enabled = true;
            }

        }

    }

}