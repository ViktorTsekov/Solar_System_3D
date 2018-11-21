using UnityEngine;

public class ChangeThePlanetInTheMenu : ChangeThePlanetInTheMenuAbstraction {

	void Start () {
		initializeVariables ();
	}

	public override void initializeVariables ()
	{
		planets = GameObject.FindGameObjectsWithTag ("Planet");
		disableAllPlanets ();
		pickPlanet ();
	}

	public override void disableAllPlanets() {

		foreach (GameObject obj in planets) {
			obj.SetActive (false);
		}

	}

	public override void pickPlanet() {
		int randomIndex = Random.Range (0, planets.Length);
		planets [randomIndex].SetActive (true);
	}

}