using UnityEngine;

public abstract class ChangeThePlanetInTheMenuAbstraction : MonoBehaviour, Iinitialize, Iplanets {

	public GameObject[] planets {get; set;}

	public abstract void initializeVariables(); 

	public abstract void disableAllPlanets ();

	public abstract void pickPlanet ();

}