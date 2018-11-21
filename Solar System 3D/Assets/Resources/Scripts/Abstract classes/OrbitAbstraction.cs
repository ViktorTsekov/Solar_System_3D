using UnityEngine;

public abstract class OrbitAbstraction : MonoBehaviour, Iorbit {

    public Transform centerPoint { get; set;}
    public float timer { get; set;}
    public float offset { get; set;}

    public abstract void orbit();
	
}